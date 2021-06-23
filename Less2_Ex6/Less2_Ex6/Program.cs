using System;

namespace Less2_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            table firstOfficeDay = (table)0b_0011111;
            table secondOfficeDay = (table)0b_1111111;
            table thirdOfficeDay = (table)0b_1100110;
            Console.WriteLine($"Рабочий график первого офиса: {firstOfficeDay}");

            Console.WriteLine($"\nРабочий график второго офиса: {secondOfficeDay}");

            Console.WriteLine($"\nРабочий график третьего офиса: {thirdOfficeDay}");
            Console.ReadKey();
        }
    }
}
