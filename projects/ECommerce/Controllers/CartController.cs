// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using ECommerce.Data;
// using ECommerce.Models;
// using ECommerce.ViewsModels;

// namespace ECommerce.Controllers
// {
//     public class CartController:Controller
//     {
//         private readonly AppDbContext _context;
        
//         public CartController(AppDbContext context)
//         {
//             _context = context;
//         }
//         public async Task<IActionResult> Index()
//         {
//             var cart = await GetCartAsync();
//             return View(cart);

//         }
//     }
// }