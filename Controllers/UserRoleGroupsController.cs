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
    public class UserRoleGroupsController : Controller
    {
        private readonly medicalcenterContext _context;

        public UserRoleGroupsController(medicalcenterContext context)
        {
            _context = context;
        }

        // GET: UserRoleGroups
        public async Task<IActionResult> Index()
        {
            var medicalcenterContext = _context.UserRoleGroups.Include(u => u.RoleGroup).Include(u => u.User);
            return View(await medicalcenterContext.ToListAsync());
        }

        // GET: UserRoleGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRoleGroups = await _context.UserRoleGroups
                .Include(u => u.RoleGroup)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userRoleGroups == null)
            {
                return NotFound();
            }

            return View(userRoleGroups);
        }

        // GET: UserRoleGroups/Create
        public IActionResult Create()
        {
            ViewData["RoleGroupId"] = new SelectList(_context.RoleGroups, "Id", "Name");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

        // POST: UserRoleGroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,RoleGroupId")] UserRoleGroups userRoleGroups)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userRoleGroups);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleGroupId"] = new SelectList(_context.RoleGroups, "Id", "Name", userRoleGroups.RoleGroupId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", userRoleGroups.UserId);
            return View(userRoleGroups);
        }

        // GET: UserRoleGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRoleGroups = await _context.UserRoleGroups.FindAsync(id);
            if (userRoleGroups == null)
            {
                return NotFound();
            }
            ViewData["RoleGroupId"] = new SelectList(_context.RoleGroups, "Id", "Name", userRoleGroups.RoleGroupId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", userRoleGroups.UserId);
            return View(userRoleGroups);
        }

        // POST: UserRoleGroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,RoleGroupId")] UserRoleGroups userRoleGroups)
        {
            if (id != userRoleGroups.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userRoleGroups);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserRoleGroupsExists(userRoleGroups.Id))
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
            ViewData["RoleGroupId"] = new SelectList(_context.RoleGroups, "Id", "Name", userRoleGroups.RoleGroupId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", userRoleGroups.UserId);
            return View(userRoleGroups);
        }

        // GET: UserRoleGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRoleGroups = await _context.UserRoleGroups
                .Include(u => u.RoleGroup)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userRoleGroups == null)
            {
                return NotFound();
            }

            return View(userRoleGroups);
        }

        // POST: UserRoleGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userRoleGroups = await _context.UserRoleGroups.FindAsync(id);
            _context.UserRoleGroups.Remove(userRoleGroups);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserRoleGroupsExists(int id)
        {
            return _context.UserRoleGroups.Any(e => e.Id == id);
        }
    }
}
