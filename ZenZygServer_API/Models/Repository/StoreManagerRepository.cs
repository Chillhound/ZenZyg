using System.Net;
using System.Threading.Tasks;
using System.Linq;
using ZenZygServer_API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace ZenZygServer_API.Models
{
    public class StoreManagerRepository : IStoreManagerRepository
    {
        private readonly IZenZygContext _context;

        public StoreManagerRepository(IZenZygContext context)
        {
            _context = context;
        }

        public async Task<HttpStatusCode> Create(StoreManagerCreateDTO StoreManager)
        {
            var entity = new StoreManager
            {
                Name = StoreManager.Name,
                Email = StoreManager.Email,
                StoreId = StoreManager.StoreId
            };

            _context.StoreManagers.Add(entity);
            await _context.SaveChangesAsync();

            return HttpStatusCode.Created;
        }

        public async Task<StoreManagerDetailsDTO> Read(int StoreManagerId)
        {
            var entity = from s in _context.StoreManagers
                         where s.StoreManagerId == StoreManagerId
                         select new StoreManagerDetailsDTO
                         {
                             StoreManagerId = s.StoreManagerId,
                             Name = s.Name,
                             Email = s.Email
                             //StoreId = s.StoreId                             
                         };

            return await entity.FirstOrDefaultAsync();
        }

        public async Task<HttpStatusCode> Update(StoreManagerUpdateDTO StoreManager)
        {
            var entity = await _context.StoreManagers.FindAsync(StoreManager.StoreManagerId);
            if (entity == null)
            {
                return HttpStatusCode.NotFound;
            }
            entity.Name = StoreManager.Name;
            entity.Email = StoreManager.Email;
            entity.StoreId = StoreManager.StoreId;
            await _context.SaveChangesAsync();
            return HttpStatusCode.NoContent;
        }

        public async Task<HttpStatusCode> Delete(int StoreManagerId)
        {
            var entity = await _context.StoreManagers.FindAsync(StoreManagerId);

            if (entity == null)
            {
                return HttpStatusCode.NotFound;
            }

            _context.StoreManagers.Remove(entity);
            await _context.SaveChangesAsync();

            return HttpStatusCode.NoContent;
        }

    }
}