using System;

namespace _01_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Масив от 20 елемента през 5: ");
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }

        }
    }
}
