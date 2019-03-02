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
    public class RoleGroupsController : Controller
    {
        private readonly medicalcenterContext _context;

        public RoleGroupsController(medicalcenterContext context)
        {
            _context = context;
        }

        // GET: RoleGroups
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoleGroups.ToListAsync());
        }

        // GET: RoleGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleGroups = await _context.RoleGroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roleGroups == null)
            {
                return NotFound();
            }

            return View(roleGroups);
        }

        // GET: RoleGroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoleGroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] RoleGroups roleGroups)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roleGroups);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roleGroups);
        }

        // GET: RoleGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleGroups = await _context.RoleGroups.FindAsync(id);
            if (roleGroups == null)
            {
                return NotFound();
            }
            return View(roleGroups);
        }

        // POST: RoleGroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] RoleGroups roleGroups)
        {
            if (id != roleGroups.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roleGroups);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoleGroupsExists(roleGroups.Id))
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
            return View(roleGroups);
        }

        // GET: RoleGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleGroups = await _context.RoleGroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roleGroups == null)
            {
                return NotFound();
            }

            return View(roleGroups);
        }

        // POST: RoleGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roleGroups = await _context.RoleGroups.FindAsync(id);
            _context.RoleGroups.Remove(roleGroups);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoleGroupsExists(int id)
        {
            return _context.RoleGroups.Any(e => e.Id == id);
        }
    }
}
