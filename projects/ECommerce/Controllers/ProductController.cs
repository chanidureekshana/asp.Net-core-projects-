using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerce.Data;
using ECommerce.ViewsModels;
using ECommerce.Models;

namespace ECommerce.Controllers
{
    public class ProductController:Controller
    {
        private readonly AppDbContext _context ;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult>Index()
        {
            return View(await _context.Products.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _context.Products.FirstOrDefaultAsync(
                m => m.ProductId ==id
            );
            if(product == null )
            {
                return NotFound();
            }
            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Create([Bind("ProductId,Name,Description,Price,StockQuantity")] ProductModel product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var product = await _context.Products.FindAsync(id);
            if(product ==null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Edit(int id , [Bind("ProductId,Name,Description,Price,StockQuantity")]ProductModel product)
        {
            if (id != product.ProductId){
                return NotFound();
            }
            if(ModelState.IsValid){
                try {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    throw;
                }

                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
        public async Task<IActionResult>Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var product = await _context.Products
            .FirstOrDefaultAsync(m => m.ProductId == id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost , ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

    }
}