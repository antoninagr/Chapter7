using System;

namespace _26_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("1. Using formulas: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int d = i + j, val = 0, count = 0;
                    if (d < n)
                    {
                        for (int k = 1; k <= d; k++)
                        {
                            count += k;
                        }
                        val = n * n - (count + d - j);
                    }
                    else
                    {
                        for (int k = 1; k <= 2 * n - d - 2; k++)
                        {
                            count += k;
                        }
                        val = count + j - d + n;
                    }
                    Console.Write("{0,4}", val);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int d = i - j, val = 0, count = 0;
                    if (d < 0)
                    {
                        for (int k = 1; k <= n; k++)
                        {
                            count += k;
                        }
                        for (int k = -1; k >= d + 1; k--)
                        {
                            count += (n + k);
                        }
                        val = i + 1 + count;
                    }
                    else
                    {
                        for (int k = 1; k <= n - d - 1; k++)
                        {
                            count += k;
                        }
                        val = count + j + 1;
                    }
                    Console.Write("{0,4}", val);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

           
        }
    }
    }


