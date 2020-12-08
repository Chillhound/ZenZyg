using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using ZenZygServer_API.Entities;

namespace ZenZygServer_API.Models.DTO
{
    public class QueueCreateDTO
    {
        public int StoreId { get; set; }

        public virtual string TicketQueue { get; set; }
    }
}
