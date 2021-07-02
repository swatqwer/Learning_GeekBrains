using System;

namespace Less4_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца (1-12): ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 1 && num <= 12)
            {
                Console.Write($"Время года: {GetSeason(num)}");
            }
            else
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            }
            Console.ReadKey();
        }
        static string GetSeason(int numMonth)
        {
            string season = "";
            switch (numMonth)
            {
                case 12:
                case 1:
                case 2:
                    season = ((Season)1).ToString();
                    break;
                case 3:
                case 4:
                case 5:
                    season = ((Season)2).ToString();
                    break;
                case 6:
                case 7:
                case 8:
                    season = ((Season)3).ToString();
                    break;
                case 9:
                case 10:
                case 11:
                    season = ((Season)4).ToString();
                    break;
            }
            return season.ToString();
        }
    }
}
