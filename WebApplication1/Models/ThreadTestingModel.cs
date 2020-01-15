using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ThreadTestingModel
    {
        public string Thread1 { get; set; }
        public string Thread2 { get; set; }
        public string Thread3 { get; set; }
        public string Thread4 { get; set; }

       
    }

    public class BussinesLayer
    {
        public string getData1()
        {
            Task.Delay(1000).Wait();
            return "Got First Thread";
        }

        public string getData2()
        {
            Task.Delay(1000).Wait();
            return "Got Second Thread";
        }
        public string getData3()
        {
            Task.Delay(1000).Wait();
            return "Got Third Thread";
        }
        public string getData4()
        {
            Task.Delay(1000).Wait();
            return "Got Fourth Thread";
        }
    }
}
