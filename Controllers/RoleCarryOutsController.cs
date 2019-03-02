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
    public class RoleCarryOutsController : Controller
    {
        private readonly medicalcenterContext _context;

        public RoleCarryOutsController(medicalcenterContext context)
        {
            _context = context;
        }

        // GET: RoleCarryOuts
        public async Task<IActionResult> Index()
        {
            var medicalcenterContext = _context.RoleCarryOuts.Include(r => r.Role).Include(r => r.RoleGroup);
            return View(await medicalcenterContext.ToListAsync());
        }

        // GET: RoleCarryOuts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleCarryOuts = await _context.RoleCarryOuts
                .Include(r => r.Role)
                .Include(r => r.RoleGroup)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roleCarryOuts == null)
            {
                return NotFound();
            }

            return View(roleCarryOuts);
        }

        // GET: RoleCarryOuts/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Description");
            ViewData["RoleGroupId"] = new SelectList(_context.RoleGroups, "Id", "Name");
            return View();
        }

        // POST: RoleCarryOuts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoleGroupId,RoleId")] RoleCarryOuts roleCarryOuts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roleCarryOuts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Description", roleCarryOuts.RoleId);
            ViewData["RoleGroupId"] = new SelectList(_context.RoleGroups, "Id", "Name", roleCarryOuts.RoleGroupId);
            return View(roleCarryOuts);
        }

        // GET: RoleCarryOuts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleCarryOuts = await _context.RoleCarryOuts.FindAsync(id);
            if (roleCarryOuts == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Description", roleCarryOuts.RoleId);
            ViewData["RoleGroupId"] = new SelectList(_context.RoleGroups, "Id", "Name", roleCarryOuts.RoleGroupId);
            return View(roleCarryOuts);
        }

        // POST: RoleCarryOuts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoleGroupId,RoleId")] RoleCarryOuts roleCarryOuts)
        {
            if (id != roleCarryOuts.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roleCarryOuts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoleCarryOutsExists(roleCarryOuts.Id))
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
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Description", roleCarryOuts.RoleId);
            ViewData["RoleGroupId"] = new SelectList(_context.RoleGroups, "Id", "Name", roleCarryOuts.RoleGroupId);
            return View(roleCarryOuts);
        }

        // GET: RoleCarryOuts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleCarryOuts = await _context.RoleCarryOuts
                .Include(r => r.Role)
                .Include(r => r.RoleGroup)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roleCarryOuts == null)
            {
                return NotFound();
            }

            return View(roleCarryOuts);
        }

        // POST: RoleCarryOuts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roleCarryOuts = await _context.RoleCarryOuts.FindAsync(id);
            _context.RoleCarryOuts.Remove(roleCarryOuts);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoleCarryOutsExists(int id)
        {
            return _context.RoleCarryOuts.Any(e => e.Id == id);
        }
    }
}
