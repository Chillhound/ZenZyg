using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
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

        // GET: Customer
        [HttpGet("{id}", Name = "GetCustomer")]
        public async Task<ActionResult<CustomerDetailsDTO>> Get(int id)
        {
            var customerDetails = await _repository.Read(id);

            if (customerDetails == null)
            {
                return NotFound();
            }

            return customerDetails;
        }

        // POST: tags
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CustomerCreateDTO customer)
        {
            var id = await _repository.Create(customer);

            return CreatedAtAction(nameof(Get), new { id }, default);
        }

        // PUT: tags/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CustomerUpdateDTO customer)
        {
            var response = await _repository.Update(customer);
            if (response == HttpStatusCode.NotFound)
            {
                return NotFound();
            } 
            return  Ok(); 
        }

        // DELETE: tags/5
        [HttpDelete("{id}")]
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
