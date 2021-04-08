using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, last;
            Console.WriteLine("Enter your name");
            Console.WriteLine("Enter your last name");
            name = Console.ReadLine();
            last = Console.ReadLine();
            Console.WriteLine("Hello {0}",name);
             Console.ReadLine();
        }
    }
}
