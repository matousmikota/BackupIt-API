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
    public class LogsController : ControllerBase
    {
        private MyContext Logcontext = new MyContext();

        [HttpGet]
        public List<Logs> GetLogs()
        {
            return this.Logcontext.Logs.ToList();
        }

        [HttpPost]
        public Logs PublishLog(Logs log)
        {
            this.Logcontext.Logs.Add(log);
            this.Logcontext.SaveChanges();

            return log;
        }

    }
}
