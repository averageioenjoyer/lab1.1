using System;
namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers");
            Console.WriteLine(int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
