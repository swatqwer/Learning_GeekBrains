using System;
using System.IO;

namespace Less5_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText("startup.txt", $"{DateTime.Now:T}\n");
            Console.ReadKey();
        }
    }
}