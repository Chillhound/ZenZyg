using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ZenZygServer_API.Entities
{
    public interface IZenZygContext : IDisposable
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Store> Stores { get; set; }
        DbSet<StoreManager> StoreManagers { get; set; }
        DbSet<Queue> Queues { get; set; }
        DbSet<Ticket> Tickets { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
