using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ZenZygServer_API.Models;
using ZenZygServer_API.Models.DTO;
using ZenZygServer_API.Entities;

namespace ZenZygServer_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class QueueController : Controller
    {

        private readonly IQueueRepository _repository;
        public QueueController(IQueueRepository repository)
        {
            _repository = repository;
        }

        //Route needed
        [Route("createqueue/store/{storeId:int}")]
        public async Task<IActionResult> Create(int storeId)
        {
            QueueCreateDTO queue = new QueueCreateDTO
            {
                StoreId = storeId
                
            };
            int id = await _repository.Create(queue);

            return Ok();
        }

        [HttpGet("{id}", Name = "GetQueue")]
        public async Task<ActionResult<QueueDetailsDTO>> Read(int id)
        {
            var queueDetails = await _repository.Read(id);

            if (queueDetails == null)
            {
                return NotFound();
            }

            return queueDetails;
        }

        [Route("getQueueLength/ticket/{ticketId:int}")]
        public async Task<ActionResult<int>> Position(int ticketId)
        {
            var queueDetails = await _repository.CountQueue(ticketId);

            return queueDetails;
        }
    }
}
