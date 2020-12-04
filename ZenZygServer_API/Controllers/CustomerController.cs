using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ZenZygServer_API.Entities;
using ZenZygServer_API.Models;

namespace ZenZygServer_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {

        private readonly ICustomerRepository _repository; 
        
        public CustomerController(ICustomerRepository repository){
            _repository = repository;
        }

        //[HttpPost]
        //  https://localhost:44361/customer/createCustomer/name/bob/phonenumber/36
        [Route("createcustomer/name/{name}/phonenumber/{phonenumber}")]
        public async Task<IActionResult> Create(string name,string phonenumber)
        {
            CustomerCreateDTO customer = new CustomerCreateDTO
            {
               Name = name,
               PhoneNumber = phonenumber
            };
            int id = await _repository.Create(customer);

            return Ok();
        }

        // GET: Customer
        [HttpGet("{id}", Name = "GetCustomer")]
        // https://localhost:44361/customer/1
        public async Task<ActionResult<CustomerDetailsDTO>> Read(int id)
        {
            var customerDetails = await _repository.Read(id);

            if (customerDetails == null)
            {
                return NotFound();
            }

            return customerDetails;
        }

        //[HttpPut("{id}")]
        [Route("updateCustomer/id/{id}/name/{name}/phonenumber/{phonenumber}")]
        // https://localhost:44361/customer/updateCustomer/id/1/name/tom/phonenumber/334535
        public async Task<IActionResult> Update(int id, string name, string phonenumber)
        {
            var updateDTO = new CustomerUpdateDTO {
                CustomerId = id,
                Name = name,
                PhoneNumber = phonenumber
            };

            var response = await _repository.Update(updateDTO);
            if (response == HttpStatusCode.NotFound)
            {
                return NotFound();
            } 
            return  Ok(); 
        }

        [HttpDelete("{id}")]
        [Route("delete/{id:int}")]
        // https://localhost:44361/customer/delete/1
        public async Task<IActionResult> Delete(int id)
        {
             var response = await _repository.Delete(id);
            if (response == HttpStatusCode.NotFound)
            {
                return NotFound();
            } 
            return  Ok(); 
        }
    }
}
