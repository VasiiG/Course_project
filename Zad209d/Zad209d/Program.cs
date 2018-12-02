using System;

namespace Zad209d
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 1; i <= 100; i++)
            {
                int x = rand.Next(0, 132);
                if (i % 3 == 0)
                {
                    Console.WriteLine($"N:{i} x={x}");
                }
            }
        }
    }
}
