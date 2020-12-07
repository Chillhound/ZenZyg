using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;
using System.Net;
using ZenZygServer_API.Models;
using ZenZygServer_API.Entities;

namespace ZenZygServer_API.Models.Tests
{
    public class StoreManagerRepositoryTest : IDisposable
    {
        private readonly StoreManagerRepository _repository;
        private readonly SqliteConnection _connection;
        private readonly ZenZygContext _context;

        public StoreManagerRepositoryTest()
        {
            _connection = new SqliteConnection("Filename =:memory:");
            _connection.Open();
            var builder = new DbContextOptionsBuilder<ZenZygContext>().UseSqlite(_connection);
            _context = new ZenZygContext(builder.Options);
            _context.Database.EnsureCreated();

            _repository = new StoreManagerRepository(_context);
        }

        [Fact]
        public async Task Create_Store_returns_httpstatus_created()
        {
            var storeManager = new StoreManagerCreateDTO
            {
                Name = "Johnny Madsen",
                Email = "johnnyspilmester@livenation.dk",
                StoreId = 1
            };

            var entity = await _repository.Create(storeManager);

            Assert.Equal(1, entity);
        }

        [Fact]
        public async Task Create_Given_StoreManager_Returns_Created()
        {
            var storeManager = new StoreManagerCreateDTO
            {
                Name = "Johnny Madsen",
                Email = "johnnyspilmester@livenation.dk",
                StoreId = 2
            };

            var entity = await _repository.Create(storeManager);

            Assert.Equal(1, entity);
        }

        [Fact]
        public async Task Read_Given_CustomerId_Returns_StoreManager()
        {
            var storeManager = new StoreManagerCreateDTO
            {
                Name = "Johnny English",
                Email = "mrBean@livenation.dk",
                StoreId = 4
            };

            await _repository.Create(storeManager);

            var ReadStoreManager = await _repository.Read(1);
            Assert.Equal("Johnny English", storeManager.Name);
        }

        [Fact]
        public async Task Update_Given_Customer_Returns_NoContent()
        {
            var storeManager = new StoreManagerCreateDTO
            {
                Name = "Johnny Madsen",
                Email = "johnnyspilmester@livenation.dk",
                StoreId = 2
            };

            await _repository.Create(storeManager);

            var storeManagerUpdate = new StoreManagerUpdateDTO
            {
                StoreManagerId = 1,
                Name = "Kim Larsen",
                Email = "KimK@Larsen.dk",
                StoreId = 4
            };

            var result = await _repository.Update(storeManagerUpdate);

            Assert.Equal(HttpStatusCode.NoContent, result);
        }

        [Fact]
        public async Task Delete_Given_CustomerId_Returns_NoContent()
        {
            var storeManager = new StoreManagerCreateDTO
            {
                Name = "Johnny Madsen",
                Email = "johnnyspilmester@livenation.dk",
                StoreId = 2
            };

            await _repository.Create(storeManager);

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