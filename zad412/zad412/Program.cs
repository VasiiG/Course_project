using System;

namespace zad412
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
            OddNumber(a);
            Console.Write("Въведете n:");
            int n = int.Parse(Console.ReadLine());
            double[] A = new double[n];
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("A[" + i + "]=");
                A[i] = double.Parse(Console.ReadLine());
            }
            

            double[] B = new double[n];
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write("B[" + i + "]=");
                B[i] = double.Parse(Console.ReadLine());
            }

            double[] C = new double[n];
            for (int i = 0; i < C.Length; i++)
            {
                Console.Write("C[" + i + "]=");
                C[i] = double.Parse(Console.ReadLine());
            }

        }
        static void OddNumber(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] %5==0)
                {
                    count++;
                }
            }
            
            Console.WriteLine($"Брой числа, които се делят на 5: {count}");
        }
    }
}
