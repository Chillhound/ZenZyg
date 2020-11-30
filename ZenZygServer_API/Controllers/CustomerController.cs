using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenZygServer_API.Models;

namespace ZenZygServer_API.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ICustomerRepository _repository; 
        
        public CustomerController(ICustomerRepository repository){
            _repository = repository;
        }




        // GET: Customer
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<CustomerDetailsDTO>> Get(int id)
        {
            var customerDetails = await _repository.Read(id);

            if (customerDetails == null)
            {
                return NotFound();
            }

            return customerDetails;
        }


    }
}
