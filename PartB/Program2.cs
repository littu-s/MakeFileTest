using System;
using DataLayer;

namespace PartB
{
    class Program2
    {
        static void Main(string[] args)
        {
            IterateNumbers Num = new IterateNumbers();
            Console.WriteLine("\n Part B");
            Num.UpdateDictionary();

            Console.ReadLine();
        }
    }
}
