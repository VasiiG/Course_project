using System;

namespace Zad357
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Въведете име: ");
            string name = Console.ReadLine();
            int i = name.IndexOf(" ") + 1;
            int j = name.LastIndexOf(" ");
            Console.WriteLine($"{name[0]}. {name[i]}. {name.Substring(j)}");
        }
    }
}

