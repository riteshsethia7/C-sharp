using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thJan
{
    class Generic1
    {
        public bool Compare <T> (T a,T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
    }
    class Generic_Demo
    {
        static void Main()
        {
            Generic1 obj = new Generic1();
            bool resf = obj.Compare<float>(2.5f, 3.6f);
            bool resi = obj.Compare<int>(2, 3);
            Console.WriteLine("Float result = {0} \nint result = {1} ",resf,resi);
        }

    }
}
