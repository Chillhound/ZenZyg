using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenZygClient.Models
{
    public class StoreViewModel
    {
        public int StoreId { get; set; }
        
        public string Name { get; set; }

        public int? StoreManagerId { get; set; }
       
        public double Size { get; set; }

        public string Address { get; set; }
    }
}
