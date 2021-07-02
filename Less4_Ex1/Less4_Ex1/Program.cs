using System;

namespace Less4_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FullName("Иванов", "Иван", "Иванович"));
            Console.WriteLine(FullName("Cерго", "Сергей", "Сергеевич"));
            Console.WriteLine(FullName("Васечкин", "Весилий", "Васильевич"));
            Console.WriteLine(FullName("Петро", "Петр", "Петрович"));
            Console.ReadKey();
        }
        static string FullName(string lastName, string firstName, string patronymic)
        {
            return $"{firstName} {patronymic} {lastName}";
        }
    }
}
