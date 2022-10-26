using System;

namespace Basics_of_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string separator = Console.ReadLine();
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            Console.WriteLine($"{str1}{separator}{str2}{separator}{str3}");
            Console.ReadKey();
        }
    }
}
