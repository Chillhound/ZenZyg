using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;
using System.Net;
using ZenZygServer_API.Models;
using ZenZygServer_API.Entities;

namespace ZenZyg.Tests.ZenZygServer_API.Models.Tests
{
    public class TicketRepositoryTest : IDisposable
    {
        private readonly TicketRepository _repository;
        private readonly ZenZygContext _context;
        private readonly SqliteConnection _connection;

        public TicketRepositoryTest()
        {
            string cs = @"Data Source=C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygServer_API\test2.db";
             _connection = new SqliteConnection(cs);
            //_connection.Open();
            //_connection = new SqliteConnection("Filename =:memory:");
            _connection.Open();
            var builder = new DbContextOptionsBuilder<ZenZygContext>().UseSqlite(_connection);
            _context = new ZenZygContext(builder.Options);
            _context.Database.EnsureCreated();

            _repository = new TicketRepository(_context);
        }

        [Fact]
        public async Task Create_Ticket_returns_int()
        {
            var ticket = new TicketCreateDTO
            {
                StoreId = 421,
                CustomerId = 323
            };

            var entity = await _repository.Create(ticket);
            //var entity = await _repository.Create(customer);

            Assert.Equal(1, entity);
        }

        public void Dispose()
        {
            _connection.Dispose();
            _context.Dispose();
        }
    }
}
