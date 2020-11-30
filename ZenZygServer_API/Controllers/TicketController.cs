using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenZygServer_API.Entities;
using ZenZygServer_API.Models;

namespace ZenZygServer_API.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketRepository _repository;
        private readonly ZenZygContext _context;
        private readonly SqliteConnection _connection;
        public TicketController(ITicketRepository repository )
        {

            //string connection = @"Data Source=\Users\mathi\Desktop\ZenZyg\ZenZyg.Tests\test.db";
            _connection = new SqliteConnection("Filename =:memory:");
            _connection.Open();
            var builder = new DbContextOptionsBuilder<ZenZygContext>().UseSqlite(_connection);
            _context = new ZenZygContext(builder.Options);
            _context.Database.EnsureCreated();

            _repository = new TicketRepository(_context);
        }




    }
}
