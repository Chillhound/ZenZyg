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
    
    public class CustomerRepositoryTest : IDisposable
    {
        private readonly CustomerRepository _repository;
        private readonly ZenZygContext _context;
        private readonly SqliteConnection _connection;

        public CustomerRepositoryTest()
        {

            //string connection = @"Data Source=\Users\mathi\Desktop\ZenZyg\ZenZyg.Tests\test.db";
           _connection = new SqliteConnection("Filename =:memory:");
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

            Assert.Equal(1, entity);
        }

        [Fact]
        public async Task Given_CustomerId_Return_Customer()
        {
            var customer = new CustomerCreateDTO
            {
                Name = "Anes",
                PhoneNumber = "12 23 45 67"
            };

            await _repository.Create(customer);

            var customerRead = await _repository.Read(1);

            Assert.Equal("12 23 45 67", customerRead.PhoneNumber);


        }

        [Fact]

        public async Task Given_CustomerId_Update_Customer()
        {
            var customer = new CustomerCreateDTO
            {
                Name = "Anes",
                PhoneNumber = "12 23 45 67"
            };

            await _repository.Create(customer);

            var customerUpdate = new CustomerUpdateDTO
            {
                CustomerId = 1,
                Name = "Mathias",
                PhoneNumber = "98 76 54 32"
            };

            await _repository.Update(customerUpdate);

            var customerRead = await _repository.Read(1);

            Assert.Equal("98 76 54 32", customerRead.PhoneNumber);
        }

        [Fact]
        public async Task Given_CustomerId_Update_Customer_returns_NoContent()
        {
            var customer = new CustomerCreateDTO
            {
                Name = "Anes",
                PhoneNumber = "12 23 45 67"
            };

            await _repository.Create(customer);

            var customerUpdate = new CustomerUpdateDTO
            {
                CustomerId = 1,
                Name = "Mathias",
                PhoneNumber = "98 76 54 32"
            };

            var result = await _repository.Update(customerUpdate);
            Assert.Equal(HttpStatusCode.NoContent, result);
        }

        [Fact]
        public async Task Given_CustomerId_Delete_Customer()
        {
            var customer = new CustomerCreateDTO
            {
                Name = "Anes",
                PhoneNumber = "12 23 45 67"
            };

            await _repository.Create(customer);

            await _repository.Delete(1);

            var result = await _repository.Read(1);

            Assert.Null(result);

        }

        [Fact]
        public async Task Given_CustomerId_Delete_Customer_returns_deleted()
        {
            var customer = new CustomerCreateDTO
            {
                Name = "Anes",
                PhoneNumber = "12 23 45 67"
            };

            await _repository.Create(customer);

            var result = await _repository.Delete(1);

            Assert.Equal(HttpStatusCode.NoContent, result);
        }

        public void Dispose()
        {
            
            _connection.Dispose();
            _context.Dispose();
        }
    }
}


