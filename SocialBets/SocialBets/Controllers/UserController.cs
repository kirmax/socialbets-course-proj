using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialBets.Areas.Identity.Pages.Account;
using SocialBets.Domain.Core.Models;
using SocialBets.Services.Interfaces;

namespace SocialBets.Controllers
{
    public class UserController : Controller
    {
        private readonly IAccountService _accountService;

        public UserController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (loginModel.ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser
                {
                    Email = loginModel.Input.Email,
                    Password = loginModel.Input.Password
                };

                var loginResult = await _accountService.Login(user);
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if (registerModel.ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser
                {
                    Email = registerModel.Input.Email,
                    Password = registerModel.Input.Password
                };

                var regResult = await _accountService.Register(user);

                if(regResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in regResult.Errors)
                    {
                        registerModel.ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View(registerModel);
        }
    }
}
