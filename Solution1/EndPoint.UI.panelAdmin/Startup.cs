using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contract;
using EndPoint.UI.panelAdmin.Models.Account;
using Infrastructures.Dal;
using Infrastructures.Dal.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EndPoint.UI.panelAdmin
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
            services.AddControllersWithViews();
            services.AddDbContext<BizContext>(options => options.UseSqlServer
            (Configuration.GetConnectionString("storeDb")));
            services.AddScoped<IOrderRepo, OrderRepository>();
            services.AddScoped<IPruductRepo, ProductRepository>();
            services.AddScoped<ICategoriRepo, CategoriRepo>();

            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("storeUserDb")));

            //services.AddIdentity<IdentityUser, IdentityRole>()
            //.AddEntityFrameworkStores<AppIdentityDbContext>()
            //.AddDefaultTokenProviders();


            services.AddIdentity<IdentityUser, IdentityRole>(c => {

                c.Password.RequireDigit = false;
                c.Password.RequiredLength = 5;
                c.Password.RequireNonAlphanumeric = false;
                //c.Password.RequireNonLetterOrDigi = false;

                c.Password.RequireUppercase = false;
                c.Password.RequireLowercase = false;


            }).AddEntityFrameworkStores<AppIdentityDbContext>()
            //.AddUserStore<AppIdentityDbContext>()
            //.AddRoleStore<AppIdentityDbContext>()
            //.AddUserManager<AppIdentityDbContext>()
            //.AddRoleManager<AppIdentityDbContext>()
            .AddDefaultTokenProviders();

            //services.UseCookieAuthentic

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
           .AddCookie();



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


            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();
            //app.UseCookieAuthenticati
                
           
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=View}/{action=ViewAllOrder}/{id?}");
            });
        }
    }
}
