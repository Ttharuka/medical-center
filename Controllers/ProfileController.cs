using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medcs.Common.Medcs.Common.Utils.Helpers;
using Medcs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Medcs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "admin, patients, child patients")]

    public class ProfileController : ControllerBase
    {
        private readonly medicalcenterContext _context;

        private readonly AppSettings _appSettings;

        public ProfileController(medicalcenterContext context, IOptions<AppSettings> appsettings)
        {
            _context = context;
            _appSettings = appsettings.Value;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("user_id")))
            {
                int user_id = int.Parse(HttpContext.Session.GetString("user_id"));
                var users = await _context.Users
                .Include(u => u.Appointments)
                .FirstOrDefaultAsync(m => m.Id == user_id);

                return Ok(users);
            }
            return Ok();
        }

        [HttpGet("test")]
        public ActionResult Test()
        {
            return Ok("Okay");
        }
    }
}