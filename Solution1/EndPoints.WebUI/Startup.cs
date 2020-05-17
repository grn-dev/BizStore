using System;
using System.Collections.Generic;
using System.Linq;
using Core.Domian;
using System.Threading.Tasks;
using Core.Contract;
using Infrastructures.Dal;
using Infrastructures.Dal.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EndPoints.WebUI.Models.Carts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace EndPoints.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSession();
            services.AddMemoryCache();

            services.AddScoped(sp => SessionCart.GetCart(sp));
            //services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddControllersWithViews();
            services.AddDbContext<BizContext>(options => options.UseSqlServer
            (Configuration.GetConnectionString("storeDb")));
            services.AddScoped<IPruductRepo, ProductRepository>();
            services.AddScoped<ICategoriRepo, CategoriRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();//id ke user pass mide
            
            app.UseRouting();
            app.UseAuthorization();

            //app.UseMvc(ru =>
            //ru.MapRoute(name: null,
            //template: "{{controller=Home}/{action=Index}/{id?}}")
            //);   

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: null,
                pattern: "{catname}/Page{pn:int}",
                defaults: new { controller = "Prouduct", action = "index" }
                );


                endpoints.MapControllerRoute(
                name: "default",
                pattern: "Page{pn:int}",
                defaults: new {
                    controller = "Prouduct",
                    action = "List",
                    productPage = 1
                });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


        }
    }
}
