using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenZygServer_API.Entities;

namespace ZenZygServer_API.Models
{
    public class TicketRepository : ITicketRepository
    {
        private readonly IZenZygContext _context;

        public TicketRepository(IZenZygContext context)
        {
            _context = context;
        }
    }
}
