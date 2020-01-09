using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thJan
{
    class Event_Demo
    {
        public delegate void Mydel(int a, int b);
        public static event Mydel event1;
        public static event Mydel event2;
        void M1(int x, int y)
        {
            Console.WriteLine("It is method M1 \n Sum = {0}", x + y);
        }
        public void M2(int x, int y)
        {
            Console.WriteLine("It is method M2 \n Product = {0}", x * y);
        }
        static void Main()
        {
            Event_Demo e1 = new Event_Demo();
            event1 += new Mydel(e1.M1);
            event2 += new Mydel(e1.M2);
            event1(3, 4);
            event2(3, 3);
        }
    }
}
