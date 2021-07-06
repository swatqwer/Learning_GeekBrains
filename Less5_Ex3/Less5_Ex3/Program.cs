using System;
using System.IO;

namespace Less5_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "Numbers.bin";
            byte[] bForFile = new byte[5];

            Console.WriteLine("Введите с клавиатуры произвольный набор чисел(0...255).");
            var str = Console.ReadLine();
            for (int i = 0; i < bForFile.Length; i++)
            {
                bForFile[i] = Convert.ToByte(str);
            }
            File.WriteAllBytes(filename, bForFile);
            Console.ReadKey();
        }
    }
}
