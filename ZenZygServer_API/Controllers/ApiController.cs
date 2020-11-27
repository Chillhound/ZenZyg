using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZenZygServer_API.Models;

namespace ZenZygServer_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : Controller
    {
        // GET: ApiController/Create
        [HttpGet]
        [Route("createticket")]
        public async Task<ActionResult<Ticket>> CreateTicket(string storeID, string phoneNumber)                // Check Phonenumber format
        {
            TicketGenerator ticketGenerator = new TicketGenerator();
            Ticket ticket = await ticketGenerator.GenerateTicket(phoneNumber,storeID);

            if (ticket == null) return NotFound();
            return ticket;
        }

        // POST: ApiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            { 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }

    public interface IHttpActionResult
    {
    }
}
