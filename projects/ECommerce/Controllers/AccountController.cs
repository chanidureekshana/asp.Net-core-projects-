using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using ECommerce.Data;
using ECommerce.ViewsModels;
// using ECommerce.ViewModels;
namespace ECommerce.Controllers
{
    public class AccountController:Controller
    {
        private readonly UserManager<UserModel>_userManager ;
        private readonly SignInManager<UserModel>_signInManager;

        public AccountController(UserManager<UserModel> userManager , SignInManager<UserModel> signInManager)
        {
            _userManager =userManager;
            _signInManager = signInManager ;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = new UserModel { UserName =model.Username , Email=model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user , isPersistent:false);
                    return RedirectToAction("Index" , "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty , error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Login(LoginViewModel model )
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username  , model.Password , model.RememberMe , lockoutOnFailure:false);
                
                if(result.Succeeded)
                {
                    return RedirectToAction("Index" , "Home");

                }
                ModelState.AddModelError(string.Empty , "Invalied Login Attempt.");

            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Logout ()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index" , "Home");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}