using System;

namespace Zad378
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int k = int.Parse(Console.ReadLine());
            double sum = 0;
            while (k != 0)
            {
                k = int.Parse(Console.ReadLine());
                if (k < 0)
                {
                    sum += k;
                }
            }
            Console.WriteLine(sum);

            //2
            int count = 0, number = 0;
            for (int i = 1; i <= 13; i++)
            {
                Console.WriteLine("въведи цяло число: ");
                int random = int.Parse(Console.ReadLine());
                if ((random > 0) || (random < -100))
                {
                    number += random;
                    count++;
                }
            }
            double avg = number / (double)count;
            Console.WriteLine($"avg is = {avg}");

            //3

            Console.Write("Въведете цяло положително число(3times): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("do it again: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("do it again: ");
            int c = int.Parse(Console.ReadLine());
            int d = c - b;
            int end = Pro(d) * Pro(a);
            Console.WriteLine(end);
            Console.ReadKey(true);
        }
        static int Pro(int k)
        {
            int meh = 0;
            Random rnd = new Random();
            for (int i = 0; i < k; i++)
            {
                meh = rnd.Next(-10, 10);
                meh *= meh;
            }
            return meh;

        }
    }
}
