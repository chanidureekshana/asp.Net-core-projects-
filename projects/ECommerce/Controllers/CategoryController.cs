using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerce.Data; 
using ECommerce.Models;



namespace ECommerce.Controllers
{
    public class CategoryController:Controller
    {
        private readonly AppDbContext _context;


        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        public async Task<IActionResult>Detailts(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var category = await _context.Categories.FirstOrDefaultAsync(
                m => m.CategoryId == id
            );
            if(category == null){
                return NotFound();
            }
            return View(category);
        }
        public async Task<IActionResult> Create([Bind("CategoryId , Name , Description")] CategoryModel category)
        {
            if(ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        public async Task<IActionResult>Edit(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }
            var category = await _context.Categories.FindAsync(id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id , [Bind("CategoryId , Name ,Description ")] CategoryModel category)
        {
            if(id != category.CategoryId)
            {
                return NotFound();
            }
            if(ModelState.IsValid){
                try {
                    _context.Update(category);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        public async Task<IActionResult>Delete(int? id )
        {
            if(id == null)
            {
                return NotFound();
            }
            var category = await _context.Categories.FirstOrDefaultAsync(
                m => m.CategoryId == id
            );
            if(category== null )
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost , ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
    }
}