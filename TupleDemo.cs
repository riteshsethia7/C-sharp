using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan2
{
    class TupleDemo
    {
        static void Main(string [] args)
        {
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12,13,14,Tuple.Create(15,16)));
            Console.WriteLine(numbers.Item1);
            Console.WriteLine(numbers.Item2);
            Console.WriteLine(numbers.Rest.Item1);
            Console.WriteLine(numbers.Rest.Item1.Rest.Item1.Item2);
        }
    }
}
