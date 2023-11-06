using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AuroraRD.Areas.Identity.Data;
using AuroraRD.Models;

namespace AuroraRD.Controllers
{
    public class LiquidoesController : Controller
    {
        private readonly DBContextSample _context;

        public LiquidoesController(DBContextSample context)
        {
            _context = context;
        }

        // GET: Liquidoes
        public async Task<IActionResult> Index()
        {
              return _context.Liquido != null ? 
                          View(await _context.Liquido.ToListAsync()) :
                          Problem("Entity set 'DBContextSample.Liquido'  is null.");
        }

        // GET: Liquidoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Liquido == null)
            {
                return NotFound();
            }

            var liquido = await _context.Liquido
                .FirstOrDefaultAsync(m => m.Id == id);
            if (liquido == null)
            {
                return NotFound();
            }

            return View(liquido);
        }

        // GET: Liquidoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Liquidoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,imagen,cantidad")] Liquido liquido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(liquido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(liquido);
        }

        // GET: Liquidoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Liquido == null)
            {
                return NotFound();
            }

            var liquido = await _context.Liquido.FindAsync(id);
            if (liquido == null)
            {
                return NotFound();
            }
            return View(liquido);
        }

        // POST: Liquidoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,imagen,cantidad")] Liquido liquido)
        {
            if (id != liquido.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(liquido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LiquidoExists(liquido.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(liquido);
        }

        // GET: Liquidoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Liquido == null)
            {
                return NotFound();
            }

            var liquido = await _context.Liquido
                .FirstOrDefaultAsync(m => m.Id == id);
            if (liquido == null)
            {
                return NotFound();
            }

            return View(liquido);
        }

        // POST: Liquidoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Liquido == null)
            {
                return Problem("Entity set 'DBContextSample.Liquido'  is null.");
            }
            var liquido = await _context.Liquido.FindAsync(id);
            if (liquido != null)
            {
                _context.Liquido.Remove(liquido);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LiquidoExists(int id)
        {
          return (_context.Liquido?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
