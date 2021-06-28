using System;

namespace Less3_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] field = {
                { "X", "O", "O", "O", "O", "O", "X", "X", "O", "O",},
                { "X", "O", "O", "O", "X", "O", "O", "O", "O", "O",},
                { "X", "O", "X", "O", "O", "O", "O", "X", "O", "O",},
                { "X", "O", "X", "O", "O", "O", "O", "O", "O", "O",},
                { "O", "O", "X", "O", "O", "X", "X", "O", "O", "O",},
                { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O",},
                { "O", "O", "O", "O", "O", "O", "O", "X", "O", "O",},
                { "O", "X", "O", "O", "O", "O", "O", "O", "O", "O",},
                { "O", "X", "O", "O", "X", "X", "X", "O", "O", "O",},
                { "O", "O", "O", "O", "O", "O", "O", "O", "O", "X",} };

            Console.WriteLine("Поле боя:");
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write($"{field[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
