using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace ZenZygServer_API.Entities
{
    public class ZenZygContext : DbContext, IZenZygContext
    {
      
       public DbSet<Customer> Customers { get; set; }
       public DbSet<Store> Stores { get; set; }
       public DbSet<StoreManager> StoreManagers { get; set; }
       public DbSet<Queue> Queues { get; set; }
       public DbSet<Ticket> Tickets { get; set; }

        public ZenZygContext() { }

        public ZenZygContext(DbContextOptions<ZenZygContext> options)
        : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(@"Data Source=\Users\mathi\Desktop\ZenZyg\ZenZyg.Tests\test.db");
            }

            /*
            var connectionString = @"Server=localhost\MSSQLSERVER01;Database=ZenZyg;Trusted_Connection=True;MultipleActiveResultSets=true";

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            */
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
    
}