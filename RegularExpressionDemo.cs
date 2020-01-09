using System;
using System.Text.RegularExpressions;
namespace Jan2
{
    class RegularExpressionDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter E-mail");
            String str1 = Console.ReadLine();
            Console.WriteLine("Enter Website");
            String str2 = Console.ReadLine();
            String ema = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
            String web = @"^([a-zA-Z0-9]+)\.([a-zA-Z]{2,5})$";
            Match m1 = Regex.Match(str1, ema);
            Match m2 = Regex.Match(str2, web);
            if (m1.Success)
            {
                Console.WriteLine("Valid Email");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
            if (m1.Success)
            {
                Console.WriteLine("Valid Website");
            }
            else
            {
                Console.WriteLine("Invalid Website");
            }

        }
    }
}
