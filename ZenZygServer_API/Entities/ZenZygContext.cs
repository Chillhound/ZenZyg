using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ZenZygServer_API.Models;

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
                //Replace connectinstring with own path
                optionsBuilder.UseSqlite(@"Data Source=~\ZenZygServer_API\test3.db");

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
            
            modelBuilder.Entity<Ticket>().HasIndex(t => t.Id).IsUnique().IncludeProperties(t => new { t.CustomerId, t.StoreId});
            modelBuilder.Entity<Customer>().HasIndex(c => c.CustomerId).IsUnique().IncludeProperties(c => new {c.Name, c.PhoneNumber});
            modelBuilder.Entity<Store>().HasIndex(s => s.StoreId).IsUnique().IncludeProperties(s => new {s.Name, s.StoreManagerId, s.Size, s.Address});
            modelBuilder.Entity<StoreManager>().HasIndex(sm => sm.StoreManagerId).IsUnique().IncludeProperties(sm => new {sm.StoreId, sm.Name, sm.Email});
            modelBuilder.Entity<Queue>().HasIndex(q => q.Id).IsUnique().IncludeProperties(q => new { q.StoreId, q.TicketQueue});
      


        }
    }
    
}