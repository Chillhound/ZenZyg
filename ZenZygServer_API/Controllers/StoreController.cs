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
    public class StoreController : Controller
    {

        private readonly IStoreRepository _repository;
        public StoreController(IStoreRepository repository)
        {
            _repository = repository;
        }

        // POST: tags
        //[HttpPost]
        // https://localhost:44361/store/createstore/name/Netto/storemanagerid/12/size/1.23/address/john madsens vej 420
        [Route("createStore/name/{name}/storeManager/{storeManagerId:int?}/size/{size:double}/address/{address}")]
        public async Task<IActionResult> Create(string name, int? storeManagerId, double size, string address)
        {
            StoreCreateDTO store = new StoreCreateDTO
            {
                Name = name,
                StoreManagerId = storeManagerId,
                Size = size,
                Address = address
            };
            int id = await _repository.Create(store);

            return CreatedAtAction(nameof(Read), new { id }, default);
        }

        // GET: Customer
        // https://localhost:44361/store/1
        [HttpGet("{id}", Name = "GetStore")]
        public async Task<ActionResult<StoreDetailsDTO>> Read(int id)
        {
            var storeDetails = await _repository.Read(id);

            if (storeDetails == null)
            {
                return NotFound();
            }

            return storeDetails;
        }
        
        [Route("all")]
        public async Task<ActionResult<IEnumerable<StoreListDTO>>> Read() 
        {
            return await _repository.ReadAll().ToListAsync();
        }


        // PUT: tags/5
        // https://localhost:44361/updatestore/id/1/name/aldi/storemanagerid/123/size/9.333/address/Rune Lugterbugtsvej 47, 42069 Danmaaaark
        [Route("updateStore/id/{id}/name/{name}/storemanager/{storeManagerId}/size/{size}/address/{address}")]
        public async Task<IActionResult> Update(int id, string name, int? storeManagerId, double size, string address)
        {
            StoreUpdateDTO store = new StoreUpdateDTO
            {
                StoreId = id,
                Name = name,
                StoreManagerId = storeManagerId,
                Size = size,
                Address = address
            };


            var response = await _repository.Update(store);
            if (response == HttpStatusCode.NotFound)
            {
                return NotFound();
            } 
            return  Ok(); 
        }

        // DELETE: tags/5
        //[HttpDelete("{id}")]
        // https://localhost:44361/store/delete/1
        [Route("delete/{id}")]
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
