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

    [Table("DestinationConfig")]
    public class DestinationConfig
    {
        [Key]
        public int id { get; set; }
        public int destinationid { get; set; }
        public int configid { get; set; }

    }
}
