using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndPoint.UI.panelAdmin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.UI.panelAdmin.Controllers
{
    [Authorize()]
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;
        public AccountController(UserManager<IdentityUser> userMgr,
        SignInManager<IdentityUser> signInMgr)
        {
            userManager = userMgr;
            signInManager = signInMgr;

        }
        [AllowAnonymous]
        public IActionResult AddUser(string userName, string password)//view result
        {
            userName = "sabzali";
            password = "123456aA";
            var user = new IdentityUser(userName);
            var res = userManager.CreateAsync(user, password).Result;
            var ss = res.Succeeded;
            return RedirectToAction("Login");
        }
        [AllowAnonymous]
        public ViewResult Login()
        {
            return View(new LoginModel
            {
                //ReturnUrl = returnUrl
            });
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user =
                await userManager.FindByNameAsync(loginModel.Name);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    if ((await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false)).Succeeded)
                    {

                        //return Redirect(loginModel?.ReturnUrl ?? "/View/Index");
                        return RedirectToAction("Add", "Product");
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
    }
}