using FamgarSar.Data;
using FamgarSar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamgarSar.Controllers
{
    public class AcosoLaboralController : Controller
    {
        private readonly ApplicationDbContext db;

        public AcosoLaboralController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index(string search)
        {
            if (search == null)
            {
                return View(await db.AcosoLaborals.ToListAsync());
            }
            return View(await db.AcosoLaborals
                .Where(d => d.Name.Contains(search))
                .ToListAsync());

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acoso = await db.AcosoLaborals.FirstOrDefaultAsync(m => m.AcosoLaboralId == id);
            if (acoso == null)
            {
                return NotFound();
            }
            return View(acoso);

        }
        public  IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AcosoLaboral acosoLaboral)
        {
            if (ModelState.IsValid)
            {
                db.Add(acosoLaboral);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(acosoLaboral);

        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var acoso = await db.AcosoLaborals.FindAsync(id);

            if (acoso == null)
            {
                return NotFound();
            }
            return View(acoso);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,AcosoLaboral acoso )
        {
            if (id != acoso.AcosoLaboralId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(acoso);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException )
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(acoso);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acoso = await db.AcosoLaborals.FirstOrDefaultAsync(m => m.AcosoLaboralId == id);
            if (acoso == null)
            {
                return NotFound();
            }
            return View(acoso);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var acoso = await db.AcosoLaborals.FindAsync(id);
            db.AcosoLaborals.Remove(acoso);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
