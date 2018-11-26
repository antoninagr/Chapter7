using System;

namespace _08_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter array lenght:  ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                int smallest = a[i];
                int index = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < smallest)
                    {
                        smallest = a[j];
                        index = j;
                    }
                }
                if (index > i)
                {
                    int swap = a[index];
                    a[index] = a[i];
                    a[i] = swap;
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
