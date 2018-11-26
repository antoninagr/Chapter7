using System;

namespace _07_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N>K");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(a);
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(a[a.Length - 1 - i]);

            }
        }
    }
}
