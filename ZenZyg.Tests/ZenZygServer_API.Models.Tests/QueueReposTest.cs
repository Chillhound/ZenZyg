using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;
using System.Net;
using ZenZygServer_API.Models;
using ZenZygServer_API.Entities;
using ZenZygServer_API.Models;
using ZenZygServer_API.Models.DTO;
using System.Collections;
using System.Collections.Generic;

namespace ZenZyg.Tests.ZenZygServer_API.Models.Tests
{
    public class QueueReposTest :IDisposable
    {
        private readonly SqliteConnection _connection;
        private readonly ZenZygContext _context;
        private readonly QueueRepository _repository;
        private readonly TicketRepository _repositoryTicket;

        public QueueReposTest()
        {
            //string connection = @"Data Source=\Users\mathi\Desktop\ZenZyg\ZenZyg.Tests\test.db";
            _connection = new SqliteConnection("Filename =:memory:");
            _connection.Open();
            var builder = new DbContextOptionsBuilder<ZenZygContext>().UseSqlite(_connection);
            _context = new ZenZygContext(builder.Options);
            _context.Database.EnsureCreated();

            _repository = new QueueRepository(_context);
            _repositoryTicket = new TicketRepository(_context);

        }

        [Fact]
        public async Task create_queue_return_queueID()
        {
            var queue = new QueueCreateDTO
            {
                StoreId = 1,
                TicketQueue = null
            };

            var entity = await _repository.Create(queue);
            Assert.Equal(1, entity);
        }

        [Fact]
        public async Task queue_contains_elements()
        {
            var ticket1 = new TicketCreateDTO
            {
                StoreId = 421,
                CustomerId = 324
            };
            var entityTicket1 = await _repositoryTicket.Create(ticket1);


            var ticket2 = new TicketCreateDTO
            {
                StoreId = 421,
                CustomerId = 323
            };
            var entityTicket2 = await _repositoryTicket.Create(ticket2);

           



            var queuelist = new Queue<int>();
            queuelist.Enqueue(entityTicket1);
            queuelist.Enqueue(entityTicket2);

            var queue = new QueueCreateDTO
            {
                StoreId = 1,
                TicketQueue = queuelist

            };

            var entity = await _repository.Create(queue);

            var queueRead = await _repository.Read(1);
            
            var element1 = queueRead.TicketQueue.Dequeue();


            Assert.Equal(1, element1);

        }
        public void Dispose()
        {
            _connection.Dispose();
            _context.Dispose();
        }
    }
}
