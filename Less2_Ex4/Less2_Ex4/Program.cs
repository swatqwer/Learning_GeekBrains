using System;

namespace Less2_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "ООО Лента";
            string adress = "г.Сыктывкар, Сысольское ш., д. 27";
            string zvd = "024321";
            string eklz = "12252760560";
            string inn = "7814148471";
            string reg = "13630";
            string kassa = "0024";
            string otd = "01";
            string smena = "001794";
            string doc = "00000036201";
            string firstposstart = "Коньяк HENNESSY VS";
            string firstposfin = "1.000 x 1,790.0";
            double firstposprice = 1790.00;
            string sectposstart = "Конфеты RAFFAELLO";
            string sectposfin = "1.000 x 325.0";
            double secposprice = 325.00;
            double nal = 2150.00;
            double nds = 18;
            double itog = (firstposprice + secposprice);
            Console.WriteLine($"|                {name}                |");
            Console.WriteLine($"|    {adress}    |");
            Console.WriteLine(new string('*', 43));
            Console.WriteLine($"|ЗВД №:{zvd}            ЭКЛЗ: {eklz}|");
            Console.WriteLine($"|РЕГ №:{reg}             ИНН:   {inn}|");
            Console.WriteLine($"|КАССА:{kassa} СМЕНА:{smena} ДОК:  {doc}|");
            Console.WriteLine($"|{DateTime.Now}     КАССА:{kassa}  ОТД{otd}|");
            Console.WriteLine(new string('*', 43));
            Console.WriteLine($"|             ПРОДАЖА  ТОВАРА             |");
            Console.WriteLine(new string('*', 43));
            Console.WriteLine($"|1. {firstposstart}                    | ");
            Console.WriteLine($"|{firstposfin}                     {firstposprice} | ");
            Console.WriteLine($"|2. {sectposstart}                     | ");
            Console.WriteLine($"|{sectposfin}                        {secposprice} | ");
            Console.WriteLine(new string('*', 43));
            Console.WriteLine($"|             ИТОГО К ОПЛАТЕ        ={itog} |");
            Console.WriteLine($"|                   НАЛИЧНЫЕ        ={nal} |");
            Console.WriteLine($"|                     СДАЧА           ={nal-itog} |");
            Console.WriteLine($"| НДС СТАВКА ------НЕТТО   СУММА ---- НДС |");
            Console.WriteLine($"| А    {nds}         {(itog - itog *nds/100)}            {(itog * nds / 100)} |");
            Console.WriteLine(new string('*', 43));

            Console.ReadKey();
        }        
    }
}
