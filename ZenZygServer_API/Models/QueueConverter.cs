using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenZygServer_API.Models
{
    public class QueueConverter
    {
      
        public string QueueToString(Queue<int> q)
        {
            string data = "";
            Console.WriteLine(q.Count);
            while (q.Count > 0) {
                var d = q.Dequeue();
                
                data = data + d + ",";
            }

            return data;
        }
        public Queue<int> StringToQueue(string s)
        {
            var q = new Queue<int>();

            string[] data = s.Split(',');

            foreach (var d in data)
            {
                if (d == "") break;
                q.Enqueue(Int32.Parse(d));
            }
            return q;
        }

    }
}
