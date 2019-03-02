using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Medcs.Common.Medcs.Common.Utils.Cryptography;
using Medcs.Common.Medcs.Common.Utils.Helpers;
using Medcs.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;

namespace Medcs.Controllers
{


    [EnableCors("AllowMyOrigin")]

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly medicalcenterContext _context;

        private readonly AppSettings _appSettings;

        public AuthController(medicalcenterContext context, IOptions<AppSettings> appsettings)
        {
            _context = context;
            _appSettings = appsettings.Value;
        }

        //[HttpPost("test")]

        //public ActionResult Test(string users)
        //{
        //    JObject jObject = JObject.Parse(users);
        //    return Ok("done "+jObject.username);
        //}

        [HttpGet("mobilelogin/{email}/{password}")]

        public ActionResult MobileLogin(string email, string password)
        {
            if (email == null || password == null)
            {
                return Ok("Invalid Request");
            }

            //Users userParam = request;
            string pass = Hashing.CalculateMD5Hash(password);



            var user = _context.Users
                .Include(u => u.Patients)
                .Include("Patients.Appointments.Prescriptions")
                .Include(u => u.Inventories)
                .Include(u => u.UserRoleGroups)
                .ThenInclude(rg => rg.RoleGroup)
                .ThenInclude(rco => rco.RoleCarryOuts)
                .ThenInclude(r => r.Role)
                .SingleOrDefault(u => u.Email == email
            && u.Password == pass);

            //var appointments = _context.Appointments.Include(a => a.Clinic)
            //            .Include(a => a.CreatedByNavigation).Include(a => a.Doctor)
            //            .Include(a => a.Patient).Include(a => a.Session)
            //            .Where(a => a.Patient.UserId == user.Id );

            //user.Appointments = appointments;


            if (user == null)
            {
                return Ok("Invalid Credentials, User Not Found");
                //return Forbid("Invalid Credentials");
            }

            //List<string> roles = new List<string>();

            //foreach(UserRoleGroups urg in user.UserRoleGroups)
            //{
            //    RoleGroups rg = urg.RoleGroup;

            //    foreach(RoleCarryOuts rco in rg.RoleCarryOuts)
            //    {
            //        roles.Add(rco.Role.Description);
            //    }
            //}

            //string role = user.UserRoleGroups.SingleOrDefault().RoleGroup.RoleCarryOuts.SingleOrDefault().Role.Description;

            //security key
            string securityKey = _appSettings.JwtKey;
            //symmetric security key
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

            //signing credentials
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            bool isManager = false;
            bool isDoctor = false;
            bool isAdmin = false;
            bool isPatient = false;
            bool isAccountant = false;

            //add claims
            var claims = new List<Claim>();
            //claims.Add(new Claim(ClaimTypes.Role, "Administrator"));
            //claims.Add(new Claim(ClaimTypes.Role, "Reader"));
            //claims.Add(new Claim("RoleGroup", role));
            claims.Add(new Claim(ClaimTypes.Name, user.Name));
            claims.Add(new Claim(ClaimTypes.Email, user.Email));

            HttpContext.Session.SetString("Name", user.Name);
            HttpContext.Session.SetString("Email", user.Email);

            foreach (UserRoleGroups urg in user.UserRoleGroups)
            {
                RoleGroups rg = urg.RoleGroup;

                if (rg.Name == "managers")
                {

                    HttpContext.Session.SetString("isManager", "1");
                    isManager = true;
                }
                if (rg.Name == "accountants")
                {
                    HttpContext.Session.SetString("isAccountant", "1");
                    isAccountant = true;
                }

                if (rg.Name == "patients")
                {
                    HttpContext.Session.SetString("isPatient", "1");
                    isPatient = true;
                }

                if (rg.Name == "doctors")
                {
                    HttpContext.Session.SetString("isDoctor", "1");
                    isDoctor = true;
                }

                if (rg.Name == "admins")
                {
                    HttpContext.Session.SetString("isAdmin", "1");
                    isAdmin = true;
                }

                claims.Add(new Claim("RoleGroup", rg.Name));

                foreach (RoleCarryOuts rco in rg.RoleCarryOuts)
                {
                    claims.Add(new Claim(ClaimTypes.Role, rco.Role.Description));
                }
            }

            claims.Add(new Claim("Id", user.Id.ToString()));


            //create token
            var token = new JwtSecurityToken(
                    issuer: "mutants",
                    audience: "users",
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: signingCredentials
                    , claims: claims
                );

            user.Password = null;
            user.Token = new JwtSecurityTokenHandler().WriteToken(token);

            HttpContext.Session.SetString("user_id", user.Id.ToString());
            HttpContext.Session.SetObject("user", user);

            //return token
            return Ok(user);
        }

        [HttpPost("login")]
        public ActionResult Login(Users userParam)
        {
            string pass = Hashing.CalculateMD5Hash(userParam.Password);
            var user = _context.Users
                .Include(u => u.Appointments)
                .Include(u => u.UserRoleGroups)
                .ThenInclude(rg => rg.RoleGroup)
                .ThenInclude(rco => rco.RoleCarryOuts)
                .ThenInclude(r => r.Role)
                .SingleOrDefault(u => u.Email == userParam.Email
            && u.Password == pass);


            if (user == null)
            {
                return Ok("Invalid Credentials");
                //return Forbid("Invalid Credentials");
            }

            //List<string> roles = new List<string>();

            //foreach(UserRoleGroups urg in user.UserRoleGroups)
            //{
            //    RoleGroups rg = urg.RoleGroup;

            //    foreach(RoleCarryOuts rco in rg.RoleCarryOuts)
            //    {
            //        roles.Add(rco.Role.Description);
            //    }
            //}

            //string role = user.UserRoleGroups.SingleOrDefault().RoleGroup.RoleCarryOuts.SingleOrDefault().Role.Description;

            //security key
            string securityKey = _appSettings.JwtKey;
            //symmetric security key
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

            //signing credentials
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            //add claims
            var claims = new List<Claim>();
            //claims.Add(new Claim(ClaimTypes.Role, "Administrator"));
            //claims.Add(new Claim(ClaimTypes.Role, "Reader"));
            //claims.Add(new Claim("RoleGroup", role));
            claims.Add(new Claim(ClaimTypes.Name, user.Name));
            claims.Add(new Claim(ClaimTypes.Email, user.Email));

            foreach (UserRoleGroups urg in user.UserRoleGroups)
            {
                RoleGroups rg = urg.RoleGroup;

                claims.Add(new Claim("RoleGroup", rg.Name));

                foreach (RoleCarryOuts rco in rg.RoleCarryOuts)
                {
                    claims.Add(new Claim(ClaimTypes.Role, rco.Role.Description));
                }
            }

            claims.Add(new Claim("Id", user.Id.ToString()));


            //create token
            var token = new JwtSecurityToken(
                    issuer: "mutants",
                    audience: "users",
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: signingCredentials
                    , claims: claims
                );

            user.Password = null;
            user.Token = new JwtSecurityTokenHandler().WriteToken(token);

            HttpContext.Session.SetString("user_id", user.Id.ToString());
            HttpContext.Session.SetObject("user", user);

            //return token
            return Ok(user);
        }

        [HttpPost("logout")]
        public ActionResult Logout()
        {
            if(!string.IsNullOrEmpty(HttpContext.Session.GetString("user_id")))
            {
                HttpContext.Session.Remove("user_id");
            }

            if(HttpContext.Session.GetObject<Users>("user") != null)
            {
                HttpContext.Session.Remove("user");
            }

            HttpContext.Session.Clear();

            return Ok("success");
        }

    }
}