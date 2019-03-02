using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medcs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Medcs.Controllers
{
    public class DashboardController : Controller
    {

        private readonly medicalcenterContext _context;

        public DashboardController(medicalcenterContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            string uid = HttpContext.Session.GetString("user_id");
            var user = new Users();
            if (!string.IsNullOrEmpty(uid))
            {
                int user_id = int.Parse(uid);
                user = _context.Users.FirstOrDefault(m => m.Id == user_id);
            }
            ViewBag.User = user;
            return View();
        }
    }
}