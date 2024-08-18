using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ECommerce.Models;
using ECommerce.Data; 

namespace ECommerce.Controllers
{
    [Authorize]
    public class BaseController:Controller
    {
        protected readonly UserManager<UserModel>_userManager;
        protected readonly SignInManager<UserModel>_signInManager;

        public BaseController(UserManager<UserModel>userManager , SignInManager<UserModel>signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        protected async Task<UserModel>GetCurrentUserAsync()
        {
            return await _userManager.GetUserAsync(User);
        }
        protected IActionResult HandleError(string message)
        {
            TempData["Error"] = message;
            return RedirectToAction("Index" , "Home");
        }
        
    }
}