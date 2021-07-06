using System;
using System.IO;

namespace Less5_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название текстового файла без расширения: ");
            string filename = Console.ReadLine();
            Console.Write("Введите произвольный набор данных: ");
            string str = Console.ReadLine();
            File.WriteAllText(filename+".txt", str);
            Console.ReadKey();
        }        
    }
}
