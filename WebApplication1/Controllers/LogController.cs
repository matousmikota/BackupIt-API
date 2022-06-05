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
    public class LogController : ControllerBase
    {
        private MyContext Logcontext = new MyContext();

        [HttpGet]
        public List<Log> GetLogs()
        {
            return this.Logcontext.Log.ToList();
        }

        [HttpPost]
        public Log PublishLog(Log log)
        {
            this.Logcontext.Log.Add(log);
            this.Logcontext.SaveChanges();

            return log;
        }

    }
}
