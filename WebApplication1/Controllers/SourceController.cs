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
    public class SourceController : ControllerBase
    {
        private MyContext Sourcecontext = new MyContext();

        [HttpGet]
        public List<Sources> GetSources()
        {
            return this.Sourcecontext.Sources.ToList();
        }

        [HttpPost]
        public Sources Create(Sources source)
        {
            this.Sourcecontext.Sources.Add(source);
            this.Sourcecontext.SaveChanges();

            return source;
        }

        [HttpPut]
        [Route("{id}")]
        public void Update(int id, Sources CConfig)
        {
            Sources db = this.Sourcecontext.Sources.Find(id);
            db.config_id = CConfig.config_id;
            db.path = CConfig.path;

            this.Sourcecontext.SaveChanges();
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            Sources source = this.Sourcecontext.Sources.Find(id);
            this.Sourcecontext.Sources.Remove(source);
            this.Sourcecontext.SaveChanges();
        }

    }
}
