using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("data/[controller]")]
    [ApiController]
    public class DestinationsController : ControllerBase
    {
        private MyContext Destinationcontext = new MyContext();

        [HttpGet]
        public List<Destinations> GetDestinations()
        {
            return this.Destinationcontext.Destinations.ToList();
        }

        [HttpPost]
        public Destinations Create(Destinations dest)
        {
            this.Destinationcontext.Destinations.Add(dest);
            this.Destinationcontext.SaveChanges();

            return dest;
        }

        [HttpPut]
        [Route("{id}")]
        public void Update(int id, Destinations dest)
        {
            Destinations db = this.Destinationcontext.Destinations.Find(id);
            db.name = dest.name;
            db.path = dest.path;
            db.type = dest.type;
            db.login = dest.login;
            db.password = dest.password;

            this.Destinationcontext.SaveChanges();
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            Destinations dest = this.Destinationcontext.Destinations.Find(id);
            this.Destinationcontext.Destinations.Remove(dest);
            this.Destinationcontext.SaveChanges();
        }
    }
}
