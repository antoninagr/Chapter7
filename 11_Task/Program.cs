using System;

namespace _11_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array lenght: ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("sum = ");
            int sum = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                int s = 0;
                for (int j = i; j < n; j++)
                {
                    s += a[j];
                    if (s == sum)
                    {

                        for (int k = i; k <= j; k++)
                        {
                            Console.WriteLine(a[k]);
                        }
                        return;
                    }
                }
            }
            Console.WriteLine("No sum of consecutive elements is equal to {0}.", sum);
        }
    }
}
