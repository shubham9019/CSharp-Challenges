using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRandomizer mr = new MyRandomizer();

            string str="";
            while (str != "exit")
            {
                try
                {
                    Console.WriteLine("Enter a number for the upper bound: ");
                    str = Console.ReadLine();
                    double upperBound = Double.Parse(str);
                    Console.WriteLine("Random number between 0 and {1}: {0}", mr.GetRandomNum(upperBound), upperBound);
                }
                catch (Exception ex) { }
            }
            Console.WriteLine("\nHit Enter key to end...");
            Console.ReadLine();
        }
    }
}
