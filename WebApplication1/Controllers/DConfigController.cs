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
        public List<ConfigDestination> GetDConfigs()
        {
            return this.DConfigcontext.DConfigs.ToList();
        }

        [HttpPost]
        public ConfigDestination Create(ConfigDestination config)
        {
            this.DConfigcontext.DConfigs.Add(config);
            this.DConfigcontext.SaveChanges();

            return config;
        }

        [HttpPut]
        [Route("{configid}")]
        public void Update(int configid, ConfigDestination config)
        {
            ConfigDestination db = this.DConfigcontext.DConfigs.Find(configid);
            db.destinationid = config.destinationid;
            db.configid = config.configid;

            this.DConfigcontext.SaveChanges();
        }

        [HttpDelete]
        [Route("{configid}")]
        public void Delete(int configid)
        {
            ConfigDestination config = this.DConfigcontext.DConfigs.Find(configid);
            this.DConfigcontext.DConfigs.Remove(config);
            this.DConfigcontext.SaveChanges();
        }
    }
}
