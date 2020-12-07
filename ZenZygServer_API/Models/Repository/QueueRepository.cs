using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ZenZygServer_API.Entities;
using ZenZygServer_API.Models.DTO;

namespace ZenZygServer_API.Models.Repository
{
    public class QueueRepository :  IQueueRepository
    {
        private readonly IZenZygContext _context;

        public QueueRepository(IZenZygContext context)
        {
            _context = context;
        }

        public async Task<int> Create(QueueCreateDTO queue)
        {
            var entity = new Queue
            {
                StoreId = queue.StoreId,
                TicketQueue = queue.TicketQueue

            };

            _context.Queues.Add(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
            }

        public async Task<QueueDetailsDTO> Read(int queueid)
        {
            var queue = from q in _context.Queues
                        where q.Id == queueid
                        select new QueueDetailsDTO
                        {
                            Id = q.Id,
                            StoreId = q.StoreId,
                            TicketQueue = q.TicketQueue
                        };
            return await queue.FirstOrDefaultAsync();
        }

        public async Task<HttpStatusCode> Update(QueueUpdateDTO queue)
        {
            var entity = await _context.Queues.FindAsync(queue.id);

            if (entity == null)
            {
                return HttpStatusCode.NotFound;
            }

            entity.TicketQueue = queue.TicketQueue;


            await _context.SaveChangesAsync();

            return HttpStatusCode.NoContent;
        }
    }
}
