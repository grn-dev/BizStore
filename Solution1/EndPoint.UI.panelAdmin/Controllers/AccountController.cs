using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EndPoint.UI.panelAdmin.Models;
using EndPoint.UI.panelAdmin.Models.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.UI.panelAdmin.Controllers
{
    [Authorize()]
    public class AccountController : Controller
    {
        private UserManager<Appuser> userManager;
        private SignInManager<Appuser> signInManager;
        public AccountController(UserManager<Appuser> userMgr,
        SignInManager<Appuser> signInMgr)
        {
            userManager = userMgr;
            signInManager = signInMgr;

        }
        [AllowAnonymous]
        public IActionResult AddUser(string userName, string password)//view result
        {
            userName = "sabzali";
            password = "123456aA";
            var user = new Appuser
            {
                UserName = userName
            };
            var res = userManager.CreateAsync(user, password).Result;
            var ss = res.Succeeded;
            return RedirectToAction("Login");
        }
        
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            var d = Request.Headers;
            var d21 = Response.Headers;
            var dgdf=5; //Response.Redirect=;
            //Response.Headers.loa= "/Product/Add";
            var dgdaf = Response.StatusCode;
            var s = User.Identity.IsAuthenticated;
            //CreatedAtAction("GetClient", new { id = clientId }, clientReponseModel)
            var dder=RouteData;
            //var dders=Path.;
            if (s == true)
            {
                return RedirectToAction("Add", "Product");
            }


            return View(new LoginModel
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                Appuser user =
                await userManager.FindByNameAsync(loginModel.Name);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    if ((await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false)).Succeeded)
                    {
                        string mainurl = "/Product/Add";
                        //return RedirectToAction("Add", "Product");
                        //return Redirect("/Product/Add");
                        var rolename = await userManager.GetRolesAsync(user);
                        return LocalRedirect(mainurl);
                        var s=User.Identity.IsAuthenticated;
                        string x = loginModel?.ReturnUrl ?? "/Admin/Index";
                        return Redirect(x);
                        
                    }
                }
            }
            ModelState.AddModelError("", "Invalid name or password");
            return View(loginModel);
        }
        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await signInManager.SignOutAsync();
            return Redirect(returnUrl);
        }

        public IActionResult Add()
        {
            AddProductViewModel model = new AddProductViewModel
            {
                //CategoryForDisplay = categoryRepository.GetAll().ToList()
            };
            return View(model);
        }
    }
}