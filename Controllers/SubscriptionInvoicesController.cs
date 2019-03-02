using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Medcs.Models;

namespace Medcs.Controllers
{
    public class SubscriptionInvoicesController : Controller
    {
        private readonly medicalcenterContext _context;

        public SubscriptionInvoicesController(medicalcenterContext context)
        {
            _context = context;
        }

        // GET: SubscriptionInvoices
        public async Task<IActionResult> Index()
        {
            var medicalcenterContext = _context.SubscriptionInvoices.Include(s => s.Clinic);
            return View(await medicalcenterContext.ToListAsync());
        }

        // GET: SubscriptionInvoices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscriptionInvoices = await _context.SubscriptionInvoices
                .Include(s => s.Clinic)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscriptionInvoices == null)
            {
                return NotFound();
            }

            return View(subscriptionInvoices);
        }

        // GET: SubscriptionInvoices/Create
        public IActionResult Create()
        {
            ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Name");
            return View();
        }

        // POST: SubscriptionInvoices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClinicId,Amount,IssuedAt,PaidAt")] SubscriptionInvoices subscriptionInvoices)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subscriptionInvoices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Name", subscriptionInvoices.ClinicId);
            return View(subscriptionInvoices);
        }

        // GET: SubscriptionInvoices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscriptionInvoices = await _context.SubscriptionInvoices.FindAsync(id);
            if (subscriptionInvoices == null)
            {
                return NotFound();
            }
            ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Name", subscriptionInvoices.ClinicId);
            return View(subscriptionInvoices);
        }

        // POST: SubscriptionInvoices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClinicId,Amount,IssuedAt,PaidAt")] SubscriptionInvoices subscriptionInvoices)
        {
            if (id != subscriptionInvoices.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subscriptionInvoices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubscriptionInvoicesExists(subscriptionInvoices.Id))
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
            ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Name", subscriptionInvoices.ClinicId);
            return View(subscriptionInvoices);
        }

        // GET: SubscriptionInvoices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscriptionInvoices = await _context.SubscriptionInvoices
                .Include(s => s.Clinic)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscriptionInvoices == null)
            {
                return NotFound();
            }

            return View(subscriptionInvoices);
        }

        // POST: SubscriptionInvoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subscriptionInvoices = await _context.SubscriptionInvoices.FindAsync(id);
            _context.SubscriptionInvoices.Remove(subscriptionInvoices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubscriptionInvoicesExists(int id)
        {
            return _context.SubscriptionInvoices.Any(e => e.Id == id);
        }
    }
}
