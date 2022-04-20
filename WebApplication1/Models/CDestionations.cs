using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Org.BouncyCastle.Asn1;

namespace WebApplication1.Models
{

    [Table("Configs_Destinations")]
    public class Configs_Destinations
    {
        [Key]
        public int id { get; set; }
        public int destination_id { get; set; }
        public int config_id { get; set; }

    }
}
