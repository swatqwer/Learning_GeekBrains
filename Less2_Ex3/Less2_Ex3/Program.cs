using System;

namespace Less2_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            if (Int32.TryParse(Console.ReadLine(), out int number))
            {
                if (number / 2 != 0)
                {
                    Console.WriteLine("Это четное число");
                }
                else
                {
                    Console.WriteLine("Это нечетное число");
                }
            }
            else
            {
                Console.WriteLine("Введённые данные не являются целым числом, либо содержит недопустимые символы");
            }
            Console.ReadKey();
        }
    }
}