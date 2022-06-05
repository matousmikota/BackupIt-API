using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MyContext : DbContext
    {
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

       // public virtual DbSet<ClientConfig> CConfigs { get; set; }

        public virtual DbSet<Config> Configs { get; set; }

        public virtual DbSet<DestinationConfig> DConfigs { get; set; }
        
        public virtual DbSet<Destinations> Destinations { get; set; }

        public virtual DbSet<Log> Log { get; set; }

        public virtual DbSet<Sources> Sources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz;database=3c1_nemecpetr1c_db2;user=nemecpetr1c;password=123456;SslMode=none");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /*builder.Entity<Client>()
                .HasMany<Config>(x => x.Configs)
                .WithMany(x => x.Clients);*/
        }
    }
}
