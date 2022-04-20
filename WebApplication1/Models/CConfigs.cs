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

    
    public class ClientConfig
    {
       
        [Key]
        public int client_id { get; set; }
        public int config_id { get; set; }

        /*[ForeignKey("config_id")]
        public virtual List<Config> Config { get; set; }
        [ForeignKey("client_id")]
        public virtual List<Client> Client { get; set; }*/
    }
}
