using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcCups.Data;
using MvcCups.Models;

namespace MvcCups.Controllers
{
    public class CupsController : Controller
    {
        private readonly MvcCupsContext _context;

        public CupsController(MvcCupsContext context)
        {
            _context = context;
        }

        // GET: Cups
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cup.ToListAsync());
        }

        // GET: Cups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cup = await _context.Cup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cup == null)
            {
                return NotFound();
            }

            return View(cup);
        }

        // GET: Cups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TitleName,ManufacturingDate,Shape,Size,Colour,Price,Review")] Cup cup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cup);
        }

        // GET: Cups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cup = await _context.Cup.FindAsync(id);
            if (cup == null)
            {
                return NotFound();
            }
            return View(cup);
        }

        // POST: Cups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TitleName,ManufacturingDate,Shape,Size,Colour,Price,Review")] Cup cup)
        {
            if (id != cup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CupExists(cup.Id))
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
            return View(cup);
        }

        // GET: Cups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cup = await _context.Cup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cup == null)
            {
                return NotFound();
            }

            return View(cup);
        }

        // POST: Cups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cup = await _context.Cup.FindAsync(id);
            _context.Cup.Remove(cup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CupExists(int id)
        {
            return _context.Cup.Any(e => e.Id == id);
        }
    }
}
