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
    public class ConfigsController : ControllerBase
    {
        private MyContext Configcontext = new MyContext();

        [HttpGet]
        public List<Config> GetConfigs()
        {
            return this.Configcontext.Configs.ToList();
        }

        [HttpPost]
        public Config Create(Config config)
        {
            this.Configcontext.Configs.Add(config);
            this.Configcontext.SaveChanges();

            return config;
        }

        [HttpPut]
        [Route("{id}")]
        public void Update(int id, Config config)
        {
            Config db = this.Configcontext.Configs.Find(id);
            db.name = config.name;
            db.type = config.type;
            db.backup_cron = config.backup_cron;
            db.max_size = config.max_size;
            db.max_count = config.max_count;

            this.Configcontext.SaveChanges();
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            Config client = this.Configcontext.Configs.Find(id);
            this.Configcontext.Configs.Remove(client);
            this.Configcontext.SaveChanges();
        }
    }
}
