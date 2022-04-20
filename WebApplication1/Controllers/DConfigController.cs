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
    public class DConfigsController : ControllerBase
    {
        private MyContext DConfigcontext = new MyContext();

        [HttpGet]
        public List<Configs_Destinations> GetDConfigs()
        {
            return this.DConfigcontext.DConfigs.ToList();
        }

        [HttpPost]
        public Configs_Destinations Create(Configs_Destinations config)
        {
            this.DConfigcontext.DConfigs.Add(config);
            this.DConfigcontext.SaveChanges();

            return config;
        }

        [HttpPut]
        [Route("{id}")]
        public void Update(int id, Configs_Destinations config)
        {
            Configs_Destinations db = this.DConfigcontext.DConfigs.Find(id);
            db.id = config.id;
            db.destination_id = config.destination_id;
            db.config_id = config.config_id;

            this.DConfigcontext.SaveChanges();
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            Configs_Destinations config = this.DConfigcontext.DConfigs.Find(id);
            this.DConfigcontext.DConfigs.Remove(config);
            this.DConfigcontext.SaveChanges();
        }
    }
}
