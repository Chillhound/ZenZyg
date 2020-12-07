using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections;
using System;

namespace ZenZygServer_API.Entities
{
    public class Queue
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        public ArrayList TicketQueue { get; set; }

    }
    
}