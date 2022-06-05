using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{

    [Table("Log")]
    public class Log
    {
        [Key]
        public int Id { get; set; }

        public string client_id { get; set; }

        public string config_id { get; set; }

        public bool was_successful { get; set; }

        public DateTime start { get; set; }

        public DateTime end { get; set; }

        public string error_code { get; set; }

    }
}
