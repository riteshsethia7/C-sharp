using System;
using System.IO;
namespace _9thJan
{
    class File_Demo
    {
        static void Main(string[] args)
        {
            String p1 = @"D:\17b81a05f8\9thJan\text_files\example.txt";
            if (!File.Exists(p1))
            {
                Console.WriteLine("File does not exist");
            }
            else
            {
                String[] lines1 = File.ReadAllLines(p1);
                Console.WriteLine("Reading All Lines");
                for (int i = 0; i < lines1.Length; i++)
                {
                    Console.WriteLine("\t {0}",lines1[i]);
                }
                Console.WriteLine("Reading All text");
                String lines2 = File.ReadAllText(p1);
                Console.WriteLine(lines2);
            }
            String p2 = @"D:\17b81a05f8\9thJan\text_files\example2.txt";
            if (!File.Exists(p2))
            {
                File.Copy(p1, p2);
            }
            else
            {
                File.Delete(p2);
                Console.WriteLine("Previous file deleted and new one created");
                File.Copy(p1, p2);
            }
            Console.ReadKey();
        }
    }
}
