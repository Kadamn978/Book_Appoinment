using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;

namespace Project1.Controllers
{
    public class AppoinmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppoinmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Appoinments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Appoinment.ToListAsync());
        }

        // GET: Appoinments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appoinment = await _context.Appoinment
                .FirstOrDefaultAsync(m => m.AppId == id);
            if (appoinment == null)
            {
                return NotFound();
            }

            return View(appoinment);
        }

        // GET: Appoinments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Appoinments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FName,LName,ContactNo,EMail,AppDate,AppTime,Specialist")] Appoinment appoinment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appoinment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appoinment);
        }

        // GET: Appoinments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appoinment = await _context.Appoinment.FindAsync(id);
            if (appoinment == null)
            {
                return NotFound();
            }
            return View(appoinment);
        }

        // POST: Appoinments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FName,LName,ContactNo,EMail,AppDate,AppTime,Specialist")] Appoinment appoinment)
        {
            if (id != appoinment.AppId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appoinment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppoinmentExists(appoinment.AppId))
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
            return View(appoinment);
        }

        // GET: Appoinments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appoinment = await _context.Appoinment
                .FirstOrDefaultAsync(m => m.AppId == id);
            if (appoinment == null)
            {
                return NotFound();
            }

            return View(appoinment);
        }

        // POST: Appoinments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appoinment = await _context.Appoinment.FindAsync(id);
            _context.Appoinment.Remove(appoinment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppoinmentExists(int id)
        {
            return _context.Appoinment.Any(e => e.AppId == id);
        }
    }
}
