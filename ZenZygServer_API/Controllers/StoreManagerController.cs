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
    public class StoreManagerController : Controller
    {
        private readonly IStoreManagerRepository _repository;
      
        public StoreManagerController(IStoreManagerRepository repository )
        {
            _repository = repository;
        }
    

        // Post: ApiController/Create
        [Route("createstoremanager/store/{storeId:int}/name/{name}/email/{email}")]
        // https://localhost:44361/storemanager/createstoremanager/storeid/122/name/johnny/email/johnny@esas.dk
        //[HttpPost]
        public async Task<IActionResult> Create(int storeId, string name, string email) 
        {
            
            var createDTO = new StoreManagerCreateDTO {
                StoreId = storeId,
                Name = name,
                Email = email
            };
            
            int id = await _repository.Create(createDTO);
            //return CreatedAtAction(nameof(Get), new { id }, default);
            return Ok();
        }


        // GET: Ticket
        // https://localhost:44361/storemanager/1
        [HttpGet("{id}", Name = "GetStoreManager")]
        public async Task<ActionResult<StoreManagerDetailsDTO>> Read(int id)
        {
            var StoreManagerDetails = await _repository.Read(id);

            if (StoreManagerDetails == null)
            {
                return NotFound();
            }

            return StoreManagerDetails;
        }

        [Route("updateStoreManager/id/{id}/store/{storeId}/name/{name}/email/{email}")]
        // https://localhost:44361/storemanager/updateStoreManager/id/1/storeid/1/name/johnnytran/email/bimsbåmsbæms@john.dk
        public async Task<IActionResult> Update(int id, int storeId, string name, string email)
        {
            var updateDTO = new StoreManagerUpdateDTO {
                StoreManagerId = id,
                StoreId = storeId,
                Name = name,
                Email = email
            };

            var response = await _repository.Update(updateDTO);
            if (response == HttpStatusCode.NotFound)
            {
                return NotFound();
            } 
            return  Ok(); 
        }

        //[HttpDelete("{Id}")]
        // https://localhost:44361/storemanager/delete/1
        [Route("delete/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var StoreManagerDelete = await _repository.Delete(id);

            if (StoreManagerDelete == HttpStatusCode.NotFound)
            {
                return NotFound();
            }
            
            return Ok();
        }
    }
}
