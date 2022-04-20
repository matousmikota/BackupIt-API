using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{

    [Table("Configs")]
    public class Config
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public string type { get; set; }

        public string backup_cron { get; set; }

        public int max_size { get; set; }

        public int max_count { get; set; }

        public bool compress_into_archive { get; set; }

        [JsonIgnore()]
        public virtual List<Client> Clients { get; set; }

    }
}
