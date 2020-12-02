using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using ZenZygServer_API.Models;

namespace ZenZygServer_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : Controller
    {

        private readonly IStoreRepository _repository;
        public StoreController(IStoreRepository repository)
        {
            _repository = repository;
        }

        // GET: Customer
        [HttpGet("{id}", Name = "GetStore")]
        public async Task<ActionResult<StoreDetailsDTO>> Get(int id)
        {
            var storeDetails = await _repository.Read(id);

            if (storeDetails == null)
            {
                return NotFound();
            }

            return storeDetails;
        }

        // POST: tags
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] StoreCreateDTO store)
        {
            var id = await _repository.Create(store);

            return CreatedAtAction(nameof(Get), new { id }, default);
        }

        // PUT: tags/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] StoreUpdateDTO store)
        {
            var response = await _repository.Update(store);
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
