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

    [Table("Clients")]
    public class Client
    {
        [Key]
        public int Id { get; set; }

        public string device_name { get; set; }

        public string mac_address { get; set; }

        public string ipv4_address { get; set; }

        public DateTime last_backup { get; set; }

        public DateTime last_seen { get; set; }

        public virtual List<Config> Configs { get; set; }



    }
}
