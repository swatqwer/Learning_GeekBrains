using System;

namespace Less2_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальную температуру за сутки в °С: ");
            var maxtempnum = Console.ReadLine();
            if (!Int32.TryParse(maxtempnum, out int maxtempn))
            {
                Console.WriteLine("Некорректное число");
                Console.ReadKey();
                return;
            }

            Console.Write("Введите минимальную температуру за сутки в °С: ");
            var mintempnum = Console.ReadLine();
            if (!Int32.TryParse(mintempnum, out int mintempn))
            {
                Console.WriteLine("Некорректное число");
                Console.ReadKey();
                return;
            }
            if (maxtempn < mintempn)
            {
                Console.WriteLine("Введённая минимальная температура превышает максимальную, проверьте введённые данные");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Введите номер месяца (1-12)");
                if (Int32.TryParse(Console.ReadLine(), out int month))
                {
                    if (month <= 12 && month > 0)
                    {
                        switch (month)
                        {
                            case (int)Month.Декабрь:
                            case (int)Month.Январь:
                            case (int)Month.Февраль:
                                double weather = (double)(maxtempn + mintempn) / 2;
                                if (weather>0)
                                {
                                    Console.WriteLine($"Дождливая зима");
                                }
                                else
                                {
                                    Console.WriteLine($"Стандартная погода");
                                }
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Такого месяца не существует");
                    }
                }
                else
                {
                    Console.WriteLine("Введённый символ не соответствует числу месяца");
                }
            }

            Console.ReadKey();
        }
    }
}
