using System;

namespace Less2_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную температуру за сутки в °С");
            var maxtempnum = Console.ReadLine();
            if (!Int32.TryParse(maxtempnum, out int maxtempn))
            {
                Console.WriteLine("Некорректное число");
                return;
            }

            Console.WriteLine("Введите минимальную температуру за сутки в °С");
            var mintempnum = Console.ReadLine();
            if (!Int32.TryParse(mintempnum, out int mintempn))
            {
                Console.WriteLine("Некорректное число");
                return;
            }
            if (maxtempn < mintempn)
            {
                Console.WriteLine("Введённая минимальная температура превышает максимальную, проверьте введённые данные");
            }
            else
            {
                Console.Clear();
                double remnant = (double)(maxtempn + mintempn) / 2;
                Console.WriteLine($"Среднесуточная температура: {remnant} °С");
            }

            Console.ReadKey();
        }
    }
}