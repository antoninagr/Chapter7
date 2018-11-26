using System;

namespace _25_Task
{
    class Program
    {
          
            static void Main(string[] args)
            {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            if (1 <= k && k <= n)
            {
                int combinations = 1;
                for (int i = n; i > n - k; i--)
                {
                    combinations *= i;
                }
                Console.WriteLine("Combinations = " + combinations);

                for (int i = 0; i < combinations; i++)
                {

                    bool[] isNotAvailable = new bool[n];

                    int numberOfAvailElems = n;
                    int combinationsOfAvailElems = combinations;

                    for (int j = 0; j < k; j++)
                    {
                        numberOfAvailElems--;


                        if (numberOfAvailElems + 1 > 0)
                        {
                            combinationsOfAvailElems /= (numberOfAvailElems + 1);
                        }
                        else
                        {
                            combinationsOfAvailElems = 1;
                        }


                        int lotId = i / combinationsOfAvailElems;

                        int indexInListOfAvailElems =
                           lotId % (numberOfAvailElems + 1);

                        int x = 0;
                        int counterOfAvailElems =
                           indexInListOfAvailElems + 1;
                        while (x < n && counterOfAvailElems > 0)
                        {
                            if (!isNotAvailable[x])
                            {
                                counterOfAvailElems--;
                            }
                            x++;
                        }
                        isNotAvailable[x - 1] = true;

                        Console.Write("{0,3}", x);
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine(
                   "Invalid data! Let 1 <= k <= n.");
            }

        }
        }
    }

