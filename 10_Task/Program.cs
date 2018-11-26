using System;

namespace _10_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array lenght");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            int frequency = 0;
            int value = 0;
            for (int i = 0; i < n; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] == a[i])
                    {
                        counter++;
                    }
                }
                if (counter > frequency)
                {
                    frequency = counter;
                    value = a[i];
                }
            }

            Console.WriteLine("Most frequent number is {0} ({1} times)", value, frequency);
        }
    }
}
