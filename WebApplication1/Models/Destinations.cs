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

    [Table("Destinations")]
    public class Destinations
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public string path { get; set; }

        public string type { get; set; }

        public string login { get; set; }

        public string password { get; set; }


    }
}
