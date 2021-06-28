using System;

namespace Less3_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое слово или фразу: ");
            string str = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("В обратном порядке: ");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write($"{str[i]}");
            }
            Console.ReadKey();

        }
    }
}
