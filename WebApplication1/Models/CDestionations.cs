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

    [Table("ConfigDestination")]
    public class ConfigDestination
    {
        
        public int destinationid { get; set; }
        [Key]
        public int configid { get; set; }

    }
}
