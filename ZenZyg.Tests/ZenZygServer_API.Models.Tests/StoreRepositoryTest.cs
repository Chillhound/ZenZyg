using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Xunit;
using ZenZygServer_API.Entities;
using System.Net;

namespace ZenZygServer_API.Models.Tests
{
    public class StoreRepositoryTest : IDisposable
    {
        private readonly SqliteConnection _connection;
        private readonly ZenZygContext _context;
        private readonly StoreRepository _repository;




        public StoreRepositoryTest()
        {
            _connection = new SqliteConnection("Filename =:memory:");
            _connection.Open();
            var builder = new DbContextOptionsBuilder<ZenZygContext>().UseSqlite(_connection);
            _context = new ZenZygContext(builder.Options);
            _context.Database.EnsureCreated();

            _repository = new StoreRepository(_context);
        }

        [Fact]
        public async Task Create_Store_returns_httpstatus_created()
        {
            var store = new StoreCreateDTO
            {
                Name = "Netto",
                Address = "Amagerfælledvej 170, 2300 København S",
                Size = 1000,
                StoreManagerId = 1
            };

            var entity = await _repository.Create(store);

            Assert.Equal(HttpStatusCode.Created, entity);
        }
        /*
        [Fact]
        public async Task Given_StoreId_Return_()
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


        */

        public void Dispose()
        {
            _connection.Dispose();
            _context.Dispose();
        }
    }
}