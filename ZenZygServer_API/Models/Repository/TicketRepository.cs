using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ZenZygServer_API.Entities;
using ZenZygServer_API.Models.DTO;

namespace ZenZygServer_API.Models
{
    public class TicketRepository : ITicketRepository
    {
        private readonly IZenZygContext _context;

        public TicketRepository(IZenZygContext context)
        {
            _context = context;
        }

        public async Task<int> Create(TicketCreateDTO ticket)
        {
            TicketGenerator ticketGenerator = new TicketGenerator();
            Ticket createdTicket = await ticketGenerator.GenerateTicket(ticket);

            if (createdTicket == null) return 0;

            _context.Tickets.Add(createdTicket);
            await _context.SaveChangesAsync();

            return createdTicket.TicketId;
        }

        public async Task<TicketDetailsDTO> Read(int ticketId)
        {
            var entity = from t in _context.Tickets
            where t.TicketId == ticketId
            select new TicketDetailsDTO
            {
                TicketId = t.TicketId,
                StoreId = t.StoreId,
                QRData = t.QRData,
                CustomerId = t.CustomerId
            };
            return await entity.FirstOrDefaultAsync();

        }
        
        public async Task<HttpStatusCode> Delete(int ticketId)
        {
            var entity = await _context.Tickets.FindAsync(ticketId);
            
            if (entity == null)
            {
                return HttpStatusCode.NotFound;
            }

            _context.Tickets.Remove(entity);

            await _context.SaveChangesAsync();
            return HttpStatusCode.NoContent;
        }
    }
}
