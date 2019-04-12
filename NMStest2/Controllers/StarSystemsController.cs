using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NMStest.Models;
using NMStest2.Models;

namespace NMStest2.Controllers
{
    public class StarSystemsController : Controller
    {
        private readonly NMStest2Context _context;

        public StarSystemsController(NMStest2Context context)
        {
            _context = context;
        }

        // GET: StarSystems
        public async Task<IActionResult> Index()
        {
            return View(await _context.StarSystems.ToListAsync());
        }

        // GET: StarSystems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var starSystems = await _context.StarSystems
                .FirstOrDefaultAsync(m => m.SystemId == id);
            if (starSystems == null)
            {
                return NotFound();
            }

            return View(starSystems);
        }

        // GET: StarSystems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StarSystems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SystemId,SystemName,StarType,EconomyType,ConflictType")] StarSystems starSystems)
        {
            if (ModelState.IsValid)
            {
                _context.Add(starSystems);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(starSystems);
        }

        // GET: StarSystems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var starSystems = await _context.StarSystems.FindAsync(id);
            if (starSystems == null)
            {
                return NotFound();
            }
            return View(starSystems);
        }

        // POST: StarSystems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SystemId,SystemName,StarType,EconomyType,ConflictType")] StarSystems starSystems)
        {
            if (id != starSystems.SystemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(starSystems);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StarSystemsExists(starSystems.SystemId))
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
            return View(starSystems);
        }

        // GET: StarSystems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var starSystems = await _context.StarSystems
                .FirstOrDefaultAsync(m => m.SystemId == id);
            if (starSystems == null)
            {
                return NotFound();
            }

            return View(starSystems);
        }

        // POST: StarSystems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var starSystems = await _context.StarSystems.FindAsync(id);
            _context.StarSystems.Remove(starSystems);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StarSystemsExists(int id)
        {
            return _context.StarSystems.Any(e => e.SystemId == id);
        }
    }
}
