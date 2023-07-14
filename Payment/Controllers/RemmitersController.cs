using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Payment.Data;
using Payment.Models;

namespace Payment.Controllers
{
    public class RemmitersController : Controller
    {
        private readonly PaymentContext _context;

        public RemmitersController(PaymentContext context)
        {
            _context = context;
        }

        // GET: Remmiters
        public async Task<IActionResult> Index()
        {
              return _context.Remmiter != null ? 
                          View(await _context.Remmiter.ToListAsync()) :
                          Problem("Entity set 'PaymentContext.Remmiter'  is null.");
        }

        // GET: Remmiters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Remmiter == null)
            {
                return NotFound();
            }

            var remmiter = await _context.Remmiter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (remmiter == null)
            {
                return NotFound();
            }

            return View(remmiter);
        }

        // GET: Remmiters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Remmiters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Rem_Name,Rem_Phone,Rem_ID_NO,Rem_Src_Acc")] Remmiter remmiter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(remmiter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(remmiter);
        }

        // GET: Remmiters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Remmiter == null)
            {
                return NotFound();
            }

            var remmiter = await _context.Remmiter.FindAsync(id);
            if (remmiter == null)
            {
                return NotFound();
            }
            return View(remmiter);
        }

        // POST: Remmiters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Rem_Name,Rem_Phone,Rem_ID_NO,Rem_Src_Acc")] Remmiter remmiter)
        {
            if (id != remmiter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(remmiter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RemmiterExists(remmiter.Id))
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
            return View(remmiter);
        }

        // GET: Remmiters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Remmiter == null)
            {
                return NotFound();
            }

            var remmiter = await _context.Remmiter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (remmiter == null)
            {
                return NotFound();
            }

            return View(remmiter);
        }

        // POST: Remmiters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Remmiter == null)
            {
                return Problem("Entity set 'PaymentContext.Remmiter'  is null.");
            }
            var remmiter = await _context.Remmiter.FindAsync(id);
            if (remmiter != null)
            {
                _context.Remmiter.Remove(remmiter);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RemmiterExists(int id)
        {
          return (_context.Remmiter?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
