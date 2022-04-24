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

    [Table("Admins")]
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public string login { get; set; }

        public string password { get; set; }

        public bool send_report_email { get; set; }

        public string email_cron { get; set; }

    }
}
