using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenZygServer_API.Models;

namespace ZenZygServer_API.Controllers
{
    public class StoreController : Controller
    {

        private readonly IStoreManagerRepository _repository;
        public StoreController(IStoreManagerRepository repository)
        {
            _repository = repository;
        }




    }
}
