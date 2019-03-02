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
    public class PatientAppointmentsController : Controller
    {
        private readonly medicalcenterContext _context;

        public PatientAppointmentsController(medicalcenterContext context)
        {
            _context = context;
        }

        // GET: PatientAppointments
        public async Task<IActionResult> Index()
        {
            string uid = HttpContext.Session.GetString("user_id");
            if (!string.IsNullOrEmpty(uid))
            {
                int user_id = int.Parse(uid);
                var medicalcenterContext = _context.Appointments.Include(a => a.Clinic).Include(a => a.CreatedByNavigation).Include(a => a.Doctor).Include(a => a.Patient).Include(a => a.Session).Where(a => a.Patient.UserId == user_id);
                return View(await medicalcenterContext.ToListAsync());
            }
            else
            {
                return LocalRedirect("/login");
            }
            
        }

        // GET: PatientAppointments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointments = await _context.Appointments
                .Include(a => a.Clinic)
                .Include(a => a.CreatedByNavigation)
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.Session)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointments == null)
            {
                return NotFound();
            }

            return View(appointments);
        }

        // GET: PatientAppointments/Create
        public IActionResult Create()
        {
            ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Address");
            ViewData["CreatedBy"] = new SelectList(_context.Users, "Id", "Email");
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Phone");
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "Address");
            ViewData["SessionId"] = new SelectList(_context.Sessions, "Id", "Id");
            return View();
        }

        // POST: PatientAppointments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClinicId,PatientId,DoctorId,SessionId,AppointedAt,IsPresent,CreatedBy,Diagnosis")] Appointments appointments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appointments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Address", appointments.ClinicId);
            ViewData["CreatedBy"] = new SelectList(_context.Users, "Id", "Email", appointments.CreatedBy);
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Phone", appointments.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "Address", appointments.PatientId);
            ViewData["SessionId"] = new SelectList(_context.Sessions, "Id", "Id", appointments.SessionId);
            return View(appointments);
        }

        // GET: PatientAppointments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointments = await _context.Appointments.FindAsync(id);
            if (appointments == null)
            {
                return NotFound();
            }
            ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Address", appointments.ClinicId);
            ViewData["CreatedBy"] = new SelectList(_context.Users, "Id", "Email", appointments.CreatedBy);
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Phone", appointments.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "Address", appointments.PatientId);
            ViewData["SessionId"] = new SelectList(_context.Sessions, "Id", "Id", appointments.SessionId);
            return View(appointments);
        }

        // POST: PatientAppointments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClinicId,PatientId,DoctorId,SessionId,AppointedAt,IsPresent,CreatedBy,Diagnosis")] Appointments appointments)
        {
            if (id != appointments.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentsExists(appointments.Id))
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
            ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Address", appointments.ClinicId);
            ViewData["CreatedBy"] = new SelectList(_context.Users, "Id", "Email", appointments.CreatedBy);
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Phone", appointments.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "Address", appointments.PatientId);
            ViewData["SessionId"] = new SelectList(_context.Sessions, "Id", "Id", appointments.SessionId);
            return View(appointments);
        }

        // GET: PatientAppointments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointments = await _context.Appointments
                .Include(a => a.Clinic)
                .Include(a => a.CreatedByNavigation)
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.Session)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointments == null)
            {
                return NotFound();
            }

            return View(appointments);
        }

        // POST: PatientAppointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appointments = await _context.Appointments.FindAsync(id);
            _context.Appointments.Remove(appointments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentsExists(int id)
        {
            return _context.Appointments.Any(e => e.Id == id);
        }
    }
}
