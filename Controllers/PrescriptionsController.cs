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
    public class PrescriptionsController : Controller
    {
        private readonly medicalcenterContext _context;

        public PrescriptionsController(medicalcenterContext context)
        {
            _context = context;
        }

        // GET: Prescriptions
        public async Task<IActionResult> Index()
        {
            var medicalcenterContext = _context.Prescriptions.Include(p => p.Appointment).Include(p => p.Inventory);
            return View(await medicalcenterContext.ToListAsync());
        }

        // GET: Prescriptions/Appointments/5
        public async Task<IActionResult> Appointments(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prescriptions = await _context.Prescriptions
                .Include(p => p.Appointment)
                .Include(p => p.Inventory)
                .Where(p => p.AppointmentId == id)
                .ToListAsync();
                //.FirstOrDefaultAsync(m => m.Id == id);
            if (prescriptions == null)
            {
                return NotFound();
            }

            ViewData["AppointmentId"] = id;

            return View(prescriptions);
        }


        // GET: Prescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prescriptions = await _context.Prescriptions
                .Include(p => p.Appointment)
                .Include(p => p.Inventory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prescriptions == null)
            {
                return NotFound();
            }

            return View(prescriptions);
        }

        // GET: Prescriptions/CreateAppointment/id
        public IActionResult CreateAppointment(int? id)
        {
            ViewData["AppointmentId"] = id;
            //var inventories = _context.Inventories.Select(p => new
            //{
            //    p,
            //    Prescriptions = p.Prescriptions.Where(x => x.InventoryId == p.Id)
            //});
            //ViewData["InventoryId"] = new SelectList(inventories, "Id", "BrandName");

            ViewData["InventoryId"] = new SelectList(_context.Inventories, "Id", "BrandName");
            ViewData["Inventories"] = _context.Inventories.Include(p => p.Prescriptions);
            return View();
        }

        // GET: Prescriptions/Create
        public IActionResult Create()
        {
            ViewData["AppointmentId"] = new SelectList(_context.Appointments, "Id", "Id");
            ViewData["InventoryId"] = new SelectList(_context.Inventories, "Id", "BrandName");
            return View();
        }

        // POST: Prescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AppointmentId,InventoryId,Quantity,Dosage,Notes,IssuedAt,IsPublic")] Prescriptions prescriptions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prescriptions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AppointmentId"] = new SelectList(_context.Appointments, "Id", "Id", prescriptions.AppointmentId);
            ViewData["InventoryId"] = new SelectList(_context.Inventories, "Id", "BrandName", prescriptions.InventoryId);
            return View(prescriptions);
        }

        // GET: Prescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prescriptions = await _context.Prescriptions.FindAsync(id);
            if (prescriptions == null)
            {
                return NotFound();
            }
            ViewData["AppointmentId"] = new SelectList(_context.Appointments, "Id", "Id", prescriptions.AppointmentId);
            ViewData["InventoryId"] = new SelectList(_context.Inventories, "Id", "BrandName", prescriptions.InventoryId);
            return View(prescriptions);
        }

        // POST: Prescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AppointmentId,InventoryId,Quantity,Dosage,Notes,IssuedAt,IsPublic")] Prescriptions prescriptions)
        {
            if (id != prescriptions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prescriptions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrescriptionsExists(prescriptions.Id))
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
            ViewData["AppointmentId"] = new SelectList(_context.Appointments, "Id", "Id", prescriptions.AppointmentId);
            ViewData["InventoryId"] = new SelectList(_context.Inventories, "Id", "BrandName", prescriptions.InventoryId);
            return View(prescriptions);
        }

        // GET: Prescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prescriptions = await _context.Prescriptions
                .Include(p => p.Appointment)
                .Include(p => p.Inventory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prescriptions == null)
            {
                return NotFound();
            }

            return View(prescriptions);
        }

        // POST: Prescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prescriptions = await _context.Prescriptions.FindAsync(id);
            _context.Prescriptions.Remove(prescriptions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrescriptionsExists(int id)
        {
            return _context.Prescriptions.Any(e => e.Id == id);
        }
    }
}
