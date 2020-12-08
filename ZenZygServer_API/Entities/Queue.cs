using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZenZygServer_API.Entities
{
    public class Queue
    {
        public int Id { get; set; }

        public int StoreId { get; set; }
        
        
        public string TicketQueue { get; set; }

    }
    
}