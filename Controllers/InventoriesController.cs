using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Medcs.Models;
using Microsoft.AspNetCore.Http;

namespace Medcs.Controllers
{
    public class InventoriesController : Controller
    {
        private readonly medicalcenterContext _context;

        public InventoriesController(medicalcenterContext context)
        {
            _context = context;
        }

        // GET: Inventories
        public async Task<IActionResult> Index()
        {
            var medicalcenterContext = _context.Inventories.Include(i => i.AddedByNavigation).Include(i => i.Clinic);
            return View(await medicalcenterContext.ToListAsync());
        }

        // GET: Inventories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventories = await _context.Inventories
                .Include(i => i.AddedByNavigation)
                .Include(i => i.Clinic)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventories == null)
            {
                return NotFound();
            }

            return View(inventories);
        }

        // GET: Inventories/Create
        public IActionResult Create()
        {
            ViewData["AddedBy"] = new SelectList(_context.Users, "Id", "Email");
            ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Address");
            return View();
        }

        // POST: Inventories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClinicId,AddedBy,GenericName,BrandName,ExpiryDate,StorageTemperature,Manufacturer,Strength,Quantity,UnitPrice,BatchNo,ReorderLevel,ManufacturedDate,Notes")] Inventories inventories)
        {
            if (ModelState.IsValid)
            {
                string user_id = HttpContext.Session.GetString("user_id");

                if (!string.IsNullOrEmpty(user_id))
                {
                    int user_id_int = int.Parse(user_id);
                    inventories.AddedBy = user_id_int;
                    var user = _context.Users.FirstOrDefault(u => u.Id == user_id_int);
                    inventories.ClinicId = user.ClinicId;
                }

                _context.Add(inventories);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddedBy"] = new SelectList(_context.Users, "Id", "Email", inventories.AddedBy);
            ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Address", inventories.ClinicId);
            return View(inventories);
        }

        // GET: Inventories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventories = await _context.Inventories.FindAsync(id);
            if (inventories == null)
            {
                return NotFound();
            }
            ViewData["AddedBy"] = new SelectList(_context.Users, "Id", "Email", inventories.AddedBy);
            ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Address", inventories.ClinicId);
            return View(inventories);
        }

        // POST: Inventories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClinicId,AddedBy,GenericName,BrandName,ExpiryDate,StorageTemperature,Manufacturer,Strength,Quantity,UnitPrice,BatchNo,ReorderLevel,ManufacturedDate,Notes")] Inventories inventories)
        {
            if (id != inventories.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventories);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventoriesExists(inventories.Id))
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
            ViewData["AddedBy"] = new SelectList(_context.Users, "Id", "Email", inventories.AddedBy);
            ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Address", inventories.ClinicId);
            return View(inventories);
        }

        // GET: Inventories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventories = await _context.Inventories
                .Include(i => i.AddedByNavigation)
                .Include(i => i.Clinic)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventories == null)
            {
                return NotFound();
            }

            return View(inventories);
        }

        // POST: Inventories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventories = await _context.Inventories.FindAsync(id);
            _context.Inventories.Remove(inventories);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventoriesExists(int id)
        {
            return _context.Inventories.Any(e => e.Id == id);
        }
    }
}
