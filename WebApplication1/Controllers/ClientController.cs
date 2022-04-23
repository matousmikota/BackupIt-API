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
    public class ClientController : ControllerBase
    {
        private MyContext clientcontext = new MyContext();

        [HttpGet]
        public List<Client> GetClients()
        {
            return this.clientcontext.Clients.ToList(); 
        }
        
        [HttpGet]
        [Route("{id}")]
        public Client GetClient(int id)
        {
            return this.clientcontext.Clients.Find(id); 
        }
        
        [HttpGet]
        [Route("mac/{mac_address}")]
        public Client GetClient(string mac_address)
        {
            return this.clientcontext.Clients.SingleOrDefault(client => client.mac_address == mac_address);
        }

        [HttpPost]
        public Client Create(Client client)
        {
            this.clientcontext.Clients.Add(client);
            this.clientcontext.SaveChanges();

            return client;
        }

        [HttpPut]
        [Route("{id}")]
        public void Update(int id, Client client)
        {
            Client db = this.clientcontext.Clients.Find(id);
            db.device_name = client.device_name;
            db.mac_address = client.mac_address;
            db.ipv4_address = client.ipv4_address;
            db.last_backup = client.last_backup;
            db.last_seen = client.last_seen;

            this.clientcontext.SaveChanges();
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            Client client = this.clientcontext.Clients.Find(id);
            try
            {
                this.clientcontext.Clients.Remove(client);
                this.clientcontext.SaveChanges();
            }
            catch (System.ArgumentNullException)
            {
                Debug.WriteLine("Client cannot be removed because it does not exist.");
            }
        }
    }
}
