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
    public class TicketController : Controller
    {
        private readonly ITicketRepository _repository;
      
        public TicketController(ITicketRepository repository )
        {
            _repository = repository;
        }

        // Post: ApiController/Create
        [Route("createticket/store/{storeID:int}/customer/{customerID:int}")]
        //[HttpPost]
        public async Task<IActionResult> Create(int storeID, int customerID) 
        {
            
            TicketCreateDTO ticketCreateDTO = new TicketCreateDTO
            {
                CustomerId = customerID,
                StoreId = storeID
            };
            
            int id = await _repository.Create(ticketCreateDTO);
            //return CreatedAtAction(nameof(Get), new { id }, default);
            return Ok(id);
        }


        // GET: Ticket
        [HttpGet("{id}", Name = "GetTicket")]
        public async Task<ActionResult<TicketDetailsDTO>> Read(int id)
        {
            var TicketDetails = await _repository.Read(id);

            if (TicketDetails == null)
            {
                return NotFound();
            }

            return TicketDetails;
        }

        //[HttpDelete("{Id}")]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var TicketDetails = await _repository.Delete(id);

            if (TicketDetails == HttpStatusCode.NotFound)
            {
                return NotFound();
            }
            
            return Ok();
        }
    }
}
