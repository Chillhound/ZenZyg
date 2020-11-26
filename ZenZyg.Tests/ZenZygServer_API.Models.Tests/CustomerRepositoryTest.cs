using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using System.Net;
using ZenZygServer_API.Models;
using ZenZygServer_API.Entities;

namespace ZenZyg.Tests.ZenZygServer_API.Models.Tests
{
    //ADD REFERENCE TO PROJECT
    public class CustomerRepositoryTest : IDisposable
    {
        private readonly CustomerRepository _repository;
        private readonly ZenZygContext _context;
        private readonly SqliteConnection _connection;

        public CustomerRepositoryTest()
        {
            
           _connection = new SqliteConnection();
           _connection.Open();
           var builder = new DbContextOptionsBuilder<ZenZygContext>().UseSqlite(_connection);
            _context = new ZenZygContext(builder.Options);
            _context.Database.EnsureCreated();

            _repository = new CustomerRepository(_context);
            

        }

        [Fact]
        public async Task Create_Customer_returns_httpstatus_created()
        {
            var customer = new CustomerCreateDTO
            {
                Name = "Anes",
                PhoneNumber = "12 23 45 67"
            };

            var entity = await _repository.Create(customer);

            Assert.Equal(HttpStatusCode.Created, entity);
        }

        public void Dispose()
        {
            _connection.Dispose();
            _context.Dispose();
        }
    }
}

/*
 using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Xunit;
using ZenZygServer_API.Entities;

namespace ZenZygServer_API.Models.Tests
{
    public class StoreRepositoryTest : IDisposable
    {
        private readonly SqliteConnection _connection;
        private readonly ZenZygContext _context;
        private readonly StoreRepository _repository;




        public StoreRepositoryTest()
        {
            _connection = new SqliteConnection("Filename:=memory:");
            _connection.Open();
            var builder = new DbContextOptionsBuilder<ZenZygContext>().UseSqlite(_connection);
            _context = new ZenZygContext(builder.Options);
            _context.Database.EnsureCreated();

            _repository = new StoreRepository(_context);
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
 
 
 */
