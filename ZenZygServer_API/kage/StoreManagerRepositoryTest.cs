using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenZygServer_API.Entities;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ZenZygServer_API.Models.Tests
{
    public class StoreManagerRepositoryTest : IDisposable
    {
        private readonly StoreManagerRepository _repository;
        private readonly ZenZygContext _context;
        private readonly SqliteConnection _connection;

        public StoreManagerRepositoryTest()
        {
            _connection = new SqliteConnection("Filename:=memory:");
            _connection.Open();
            var builder = new DbContextOptionsBuilder<ZenZygContext>().UseSqlite(_connection);
            _context = new ZenZygContext(builder.Options);
            _context.Database.EnsureCreated();

            _repository = new StoreManagerRepository(_context);

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }   
}