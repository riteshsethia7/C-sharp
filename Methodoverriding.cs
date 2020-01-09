using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan2
{
    class Demo
    {
        public void example()
        {
            Console.WriteLine("This will be overidden");
        }
    }
    class DEMO : Demo
    {
        public void example()
        {
            Console.WriteLine("This will over ride");
        }
    }
    class Methodoverriding
    {
        static void Main(string[] args)
        {
            DEMO obj = new DEMO();
            obj.example();
        }
    }
}
