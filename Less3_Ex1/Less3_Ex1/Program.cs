using System;

namespace Less3_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int[,] array2 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.WriteLine($"{array2[i, j]}");
                    max++;
                    for (int k = 0; k < max; k++)
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
