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
    public class CConfigsController : ControllerBase
    {
        private MyContext CConfigcontext = new MyContext();

        [HttpPost]
        public void Add(ClientConfig cfg)
        {
            Client client = this.CConfigcontext.Clients.Find(cfg.client_id);
            Config config = this.CConfigcontext.Configs.Find(cfg.config_id);

            client.Configs.Add(config);
            this.CConfigcontext.SaveChanges();
        }

        /*[HttpGet]
        public List<ClientConfig> Get()
        {
            return this.CConfigcontext.CConfigs.ToList();
        }

        [HttpPost]
        public ClientConfig Create(ClientConfig CConfig)
        {
            this.CConfigcontext.CConfigs.Add(CConfig);
            this.CConfigcontext.SaveChanges();

            return CConfig;
        }

        [HttpPut]
        [Route("{id}")]
        public void Update(int id, ClientConfig CConfig)
        {
            ClientConfig db = this.CConfigcontext.CConfigs.Find(id);
            db.client_id = CConfig.client_id;
            db.config_id = CConfig.config_id;

            this.CConfigcontext.SaveChanges();
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            ClientConfig config = this.CConfigcontext.CConfigs.Find(id);
            this.CConfigcontext.CConfigs.Remove(config);
            this.CConfigcontext.SaveChanges();
        }
        */
    }
}
