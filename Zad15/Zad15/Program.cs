using System;

namespace Zad15
{
    class Program
    {
        public static void Main(string[] args)
        {
            double Xa, Ya, Xb, Yb;
            Console.Write("Xa=");
            Xa = double.Parse(Console.ReadLine());
            Console.Write("Ya=");
            Ya = double.Parse(Console.ReadLine());
            Console.Write("Xb=");
            Xb = double.Parse(Console.ReadLine());
            Console.Write("Yb=");
            Yb = double.Parse(Console.ReadLine());
            double result = Math.Sqrt(Math.Pow(Xa - Xb, 2) + Math.Pow(Ya - Yb, 2));
            Console.WriteLine("Result=" + result);
        }
    }
}

