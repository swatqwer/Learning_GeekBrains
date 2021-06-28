using System;

namespace Less3_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array2 = {{ "Иванов" }, {"8-800-555-3535"},
                                { "Cерго" }, {"sergey18@email.ru"},
                                { "Петров" }, {"8-800-00-0102"},
                                { "Васечкин" }, {"vasek228@mail.ru"},
                                { "Дмитриев" }, {"8-999-99-9999"} };
            Console.WriteLine("Телефонный справочник:");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                Console.Write($"{array2[i, 0]} {array2[i, 1]}");
            }
            Console.ReadKey();

        }
    }
}
