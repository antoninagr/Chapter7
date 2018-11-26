using System;

namespace _03_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-st array
            Console.Write("Enter the length of the first array: ");
            int chararrayOneLenght = int.Parse(Console.ReadLine());
            char[] chararrayOne = new char[chararrayOneLenght];
            for (int i = 0; i < chararrayOneLenght; i++)
            {
                chararrayOne[i] = char.Parse(Console.ReadLine());
            }


            //2-nd array
            Console.Write("Enter the length of the first array: ");
            int chararrayTwoLenght = int.Parse(Console.ReadLine());
            char[] chararrayTwo = new char[chararrayTwoLenght];
            bool firstIsFirst = false;
            for (int i = 0; i < chararrayTwoLenght; i++)
            {
                chararrayTwo[i] = char.Parse(Console.ReadLine());
            }

            if (chararrayOneLenght == chararrayTwoLenght)
            {

                for (int i = 0; i < chararrayOne.Length; i++)
                {
                    if ((int)chararrayOne[i] < (int)chararrayTwo[i])
                    {
                        firstIsFirst = true;
                    }
                }
                if (firstIsFirst == true)
                {
                    Console.WriteLine("The first array is before the second array");
                }
                else Console.WriteLine("The second array is before first array");
            }
            else
                Console.WriteLine("Not equal length");
        }
    }
}
