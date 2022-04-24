using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("data/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private MyContext admincontext = new MyContext();

        [HttpGet]
        public List<Admin> GetAdmins()
        {
            return this.admincontext.Admins.ToList(); 
        }
        
        [HttpGet]
        [Route("{id}")]
        public Admin GetAdmin(int id)
        {
            return this.admincontext.Admins.Find(id); 
        }

        [HttpPost]
        public Admin Create(Admin admin)
        {
            this.admincontext.Admins.Add(admin);
            this.admincontext.SaveChanges();

            return admin;
        }

        [HttpPut]
        [Route("{id}")]
        public void Update(int id, Admin admin)
        {
            Admin db = this.admincontext.Admins.Find(id);
            db.name = admin.name;
            db.login = admin.login;
            db.password = admin.password;
            db.send_report_email = admin.send_report_email;
            db.email_cron = admin.email_cron;

            this.admincontext.SaveChanges();
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            Admin admin = this.admincontext.Admins.Find(id);
            try
            {
                this.admincontext.Admins.Remove(admin);
                this.admincontext.SaveChanges();
            }
            catch (System.ArgumentNullException)
            {
                Debug.WriteLine("Admin cannot be removed because it does not exist.");
            }
        }
    }
}
