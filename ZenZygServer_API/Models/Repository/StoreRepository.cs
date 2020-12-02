using System.Net;
using System.Threading.Tasks;
using ZenZygServer_API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace ZenZygServer_API.Models
{
    public class StoreRepository : IStoreRepository
    {
        private readonly IZenZygContext _context;

        public StoreRepository(IZenZygContext context)
        {
            _context = context;
        }

        public async Task<HttpStatusCode> Create(StoreCreateDTO Store)
        {
            var entity = new Store
            {
                Name = Store.Name,
                StoreManagerId = Store.StoreManagerId,
                Size = Store.Size,
                Address = Store.Address
            };
            _context.Stores.Add(entity);
            await _context.SaveChangesAsync();
            return HttpStatusCode.Created;
        }

        public async Task<StoreDetailsDTO> Read(int StoreId)
        {
            var entity = from s in _context.Stores
            where s.StoreId == StoreId
            select new StoreDetailsDTO
            {
                StoreId = s.StoreId,
                Name = s.Name,
                StoreManagerId = s.StoreManagerId,
                Size = s.Size,
                Address = s.Address
            };
            return await entity.FirstOrDefaultAsync();

        }
        
        public async Task<HttpStatusCode> Update(StoreUpdateDTO Store)
        {
            var entity = await _context.Stores.FindAsync(Store.StoreId);

            if (entity == null)
            {
                return HttpStatusCode.NotFound;
            }

            entity.Name = Store.Name;
            entity.StoreManagerId = Store.StoreManagerId;
            entity.Size = Store.Size;
            entity.Address = Store.Address;

            await _context.SaveChangesAsync();

            return HttpStatusCode.NoContent;
        }

        public async Task<HttpStatusCode> Delete(int StoreId)
        {
            var entity = await _context.Stores.FindAsync(StoreId);
            
            if (entity == null)
            {
                return HttpStatusCode.NotFound;
            }

            _context.Stores.Remove(entity);

            await _context.SaveChangesAsync();
            return HttpStatusCode.NoContent;
        }


    }
}