using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ZenZygServer_API.Entities
{
    public class ZenZygContext : DbContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Store> Stores { get; set; }
        DbSet<StoreManager> StoreManagers { get; set; }
        DbSet<Queue> Queues { get; set; }
        DbSet<Ticket> Tickets { get; set; }

        public ZenZygContext() { }

        public ZenZygContext(DbContextOptions<ZenZygContext> options)
        : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=ZenZyg;Trusted_Connection=True;MultipleActiveResultSets=true";

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
    
}