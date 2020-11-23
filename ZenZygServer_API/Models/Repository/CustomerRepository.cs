using System.Net;
using System.Threading.Tasks;
using ZenZygServer_API.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ZenZygServer_API.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IZenZygContext _context;

        public CustomerRepository(IZenZygContext context)
        {
            _context = context;
        }


        public async Task<HttpStatusCode> Create(CustomerCreateDTO Customer)
        {
            var entity = new Customer
            {
                Name = Customer.Name,
                PhoneNumber = Customer.PhoneNumber
            };

            _context.Customers.Add(entity);
            await _context.SaveChangesAsync();

            return HttpStatusCode.Created; //Maybe return ID if needed instead
        }

        public async Task<CustomerDetailsDTO> Read(int CustomerId)
        {
            var customer = from c in _context.Customers
                           where c.CustomerId == CustomerId
                           select new CustomerDetailsDTO
                           {
                               CustomerId = c.CustomerId,
                               Name = c.Name,
                               PhoneNumber = c.PhoneNumber
                           };

            return await customer.FirstOrDefaultAsync();
        }

        public async Task<HttpStatusCode> Update(CustomerUpdateDTO Customer)
        {
            var entity = await _context.Customers.FindAsync(Customer.CustomerId);

            if (entity == null)
            {
                return HttpStatusCode.NotFound;
            }

            entity.Name = Customer.Name;
            entity.PhoneNumber = Customer.PhoneNumber;

            await _context.SaveChangesAsync();

            return HttpStatusCode.NoContent;
        }

        public async Task<HttpStatusCode> Delete(int CustomerId)
        {
            var entity = await _context.Customers.FindAsync(CustomerId);

            if (entity == null)
            {
                return HttpStatusCode.NotFound;
            }

            _context.Customers.Remove(entity);

            await _context.SaveChangesAsync();
            return HttpStatusCode.NoContent;
        }


    }
}