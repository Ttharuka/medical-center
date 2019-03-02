using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Medcs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace Medcs.Controllers
{

    //[Authorize(Roles = "admin")]

    public class ClinicsController : Controller
    {
        private readonly medicalcenterContext _context;

        public ClinicsController(medicalcenterContext context)
        {
            //if(!string.IsNullOrEmpty(HttpContext.Session.GetString("user_id")))
            //{
            //    LocalRedirect("/login");
            //}
            _context = context;
        }

        // GET: Clinics
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clinics.ToListAsync());
        }

        // GET: Clinics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clinics = await _context.Clinics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clinics == null)
            {
                return NotFound();
            }

            return View(clinics);
        }

        // GET: Clinics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clinics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,RegNo,Address,Phone,Email,SubscribedAt,BillingCycle,IsActive")] Clinics clinics)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clinics);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clinics);
        }

        // GET: Clinics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clinics = await _context.Clinics.FindAsync(id);
            if (clinics == null)
            {
                return NotFound();
            }
            return View(clinics);
        }

        // POST: Clinics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,RegNo,Address,Phone,Email,SubscribedAt,BillingCycle,IsActive")] Clinics clinics)
        {
            if (id != clinics.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clinics);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClinicsExists(clinics.Id))
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
            return View(clinics);
        }

        // GET: Clinics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clinics = await _context.Clinics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clinics == null)
            {
                return NotFound();
            }

            return View(clinics);
        }

        // POST: Clinics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clinics = await _context.Clinics.FindAsync(id);
            _context.Clinics.Remove(clinics);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClinicsExists(int id)
        {
            return _context.Clinics.Any(e => e.Id == id);
        }
    }
}
