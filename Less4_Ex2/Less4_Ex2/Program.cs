using System;

namespace Less4_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа через пробел: ");
            string num = Console.ReadLine();
            Console.Write($"Сумма введенных чисел = { Sum(num)}");
            Console.ReadKey();
        }
        static int Sum(string num)
        {
            int i = 0;
            string[] Number = num.Split(' ');

            foreach (string s in Number)
            {
                i += Convert.ToInt32(s);
            }
            return i;
        }
    }
}
