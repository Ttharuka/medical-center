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
    public class AppointmentsController : Controller
    {
        private readonly medicalcenterContext _context;

        public AppointmentsController(medicalcenterContext context)
        {
            _context = context;
        }

        // GET: Appointments
        public async Task<IActionResult> Index()
        {
            List<string> roles = new List<string>();

            var medicalcenterContext = _context.Appointments.Include(a => a.Clinic)
                        .Include(a => a.CreatedByNavigation).Include(a => a.Doctor)
                        .Include(a => a.Doctor.User)
                        .Include(a => a.Patient.User)
                        .Include(a => a.Patient).Include(a => a.Session);

            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("user_id")))
            {
                int user_id = int.Parse(HttpContext.Session.GetString("user_id"));
                var user = _context.Users
                .Include(u => u.UserRoleGroups)
                .ThenInclude(rg => rg.RoleGroup)
                .ThenInclude(rco => rco.RoleCarryOuts)
                .ThenInclude(r => r.Role)
                .SingleOrDefault(u => u.Id == user_id);

                
                foreach (UserRoleGroups urg in user.UserRoleGroups)
                {
                    RoleGroups rg = urg.RoleGroup;

                    

                    foreach (RoleCarryOuts rco in rg.RoleCarryOuts)
                    {
                        roles.Add(rco.Role.Description);
                    }
                }

                if (roles.BinarySearch("patient") >= 0)
                {
                    var medicalcenterContextPatient = _context.Appointments.Include(a => a.Clinic)
                        .Include(a => a.CreatedByNavigation).Include(a => a.Doctor)
                        .Include(a => a.Patient).Include(a => a.Session).Include(a => a.Doctor.User)
                        .Include(a => a.Patient.User)
                        .Where(a => a.Patient.UserId == user_id);
                    return View(await medicalcenterContextPatient.ToListAsync());
                }
                else
                {
                    var medicalcenterContextPatient = _context.Appointments.Include(a => a.Clinic)
                        .Include(a => a.CreatedByNavigation).Include(a => a.Doctor)
                        .Include(a => a.Doctor.User)
                        .Include(a => a.Patient).Include(a => a.Session)
                        .Include(a => a.Patient.User)
                        .Where(a => a.ClinicId == user.ClinicId);
                    return View(await medicalcenterContextPatient.ToListAsync());
                }

            }

            
            

            return View(await medicalcenterContext.ToListAsync());
        }


        [HttpGet]
        public ActionResult Present(int? id)
        {
            var appointment = _context.Appointments.SingleOrDefault(a => a.Id == id);
            if(appointment != null)
            {
                appointment.IsPresent = 1;
                _context.Update(appointment);
                _context.SaveChanges();
                

            }

            return Redirect("/Appointments");
        }


        // GET: Appointments/Patient/id
        public async Task<IActionResult> Patient(int? id)
        {
            var medicalcenterContext = _context.Appointments
                .Include(a => a.Clinic)
                .Include(a => a.CreatedByNavigation)
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.Session)
                .Where(a => a.PatientId == id);
            return View(await medicalcenterContext.ToListAsync());
        }

        // GET: Appointments/Details/5
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

        // GET: Appointments/Create
        public IActionResult Create()
        {
            ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Name");
            ViewData["CreatedBy"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["DoctorId"] = new SelectList(_context.Doctors.Include(d => d.User), "Id", "User.Name");
            ViewData["PatientId"] = new SelectList(_context.Patients.Include(u => u.User), "Id", "User.Name");
            ViewData["SessionId"] = new SelectList(_context.Sessions, "Id", "Start");
            return View();
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClinicId,PatientId,DoctorId,SessionId,AppointedAt,IsPresent,CreatedBy,Diagnosis")] Appointments appointments)
        {
            if (ModelState.IsValid)
            {
                string user_id = HttpContext.Session.GetString("user_id");
                if (!string.IsNullOrEmpty(user_id))
                {
                    int created_by = int.Parse(user_id);
                    appointments.CreatedBy = created_by;
                }
                
                _context.Add(appointments);
                await _context.SaveChangesAsync();

                var payment = new Payments();
                payment.Amount = 0;
                payment.AppointmentId = appointments.Id;
                payment.IsReceived = 0;

                _context.Add(payment);
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

        // GET: Appointments/Edit/5
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
            ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Name", appointments.ClinicId);
            ViewData["CreatedBy"] = new SelectList(_context.Users, "Id", "Email", appointments.CreatedBy);
            ViewData["DoctorId"] = new SelectList(_context.Doctors.Include(d => d.User), "Id", "User.Name", appointments.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patients.Include(p => p.User), "Id", "User.Name", appointments.PatientId);
            ViewData["SessionId"] = new SelectList(_context.Sessions, "Id", "Id", appointments.SessionId);
            return View(appointments);
        }

        // POST: Appointments/Edit/5
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

        // GET: Appointments/Delete/5
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

        // POST: Appointments/Delete/5
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
