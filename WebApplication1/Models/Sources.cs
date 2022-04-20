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

    [Table("Sources")]
    public class Sources
    {
        [Key]
        public int Id { get; set; }

        public int config_id { get; set; }

        public string path { get; set; }

    }
}
