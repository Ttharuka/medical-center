using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medcs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Stripe;

namespace Medcs.Controllers
{
    public class CardPaymentController : Controller
    {
        private readonly medicalcenterContext _context;

        public CardPaymentController(medicalcenterContext context)
        {
            _context = context;
        }

        public string Status { get; private set; }

        [BindProperty]
        public Payments Payments { get; set; }

        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payments = await _context.Payments
                .Include(p => p.Appointment).FirstOrDefaultAsync(m => m.Id == id);

            if (payments == null)
            {
                return NotFound();
            }

            ViewData["Payments"] = payments;

            ViewData["AppointmentId"] = new SelectList(_context.Appointments, "Id", "Id");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string stripeEmail, string stripeToken, int payment_id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var customers = new CustomerService();
            var charges = new ChargeService();

            var customer = customers.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                SourceToken = stripeToken
            });

            Payments payments = _context.Payments.Find(payment_id);

            long amount = (long)(payments.Amount * 100);

            var charge = charges.Create(new ChargeCreateOptions
            {
                Amount = amount,
                Description = "Medical Fee",
                Currency = "lkr",
                CustomerId = customer.Id
            });

            if (charge.Paid)
            {
                payments.IsReceived = 1;
                payments.Method = "card";
            }
            

            //var payment = _context.Payments.Where(i => i.Id == Payments.Id).First();
            //payment.IsReceived = 1;
            //_context.SaveChanges();

            //_context.Attach(Payments).State = EntityState.Modified;

            _context.Attach(payments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentsExists(Payments.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return LocalRedirect("/Payments/Details?id=" + payments.Id.ToString());

            //return RedirectToRoute("/Payment/Details?id=" + payments.Id.ToString());

            //return RedirectToPage("/Payment/Details?id="+payments.Id.ToString());
        }

        private bool PaymentsExists(int id)
        {
            return _context.Payments.Any(e => e.Id == id);
        }

        public IActionResult Charge(string stripeEmail, string stripeToken)
        {
            var customers = new CustomerService();
            var charges = new ChargeService();

            var customer = customers.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                SourceToken = stripeToken
            });

            var charge = charges.Create(new ChargeCreateOptions
            {
                Amount = 500,
                Description = "Sample Charge",
                Currency = "usd",
                CustomerId = customer.Id
            });

            return View();
        }
    }
}