using System;
using Tyuiu.SedelnikovaEA.Sprint3.Task3.V18.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "4n5nvf 56 bgy";
            char targetChar = 'n';

            Console.WriteLine("* Исходная строка = " + str);
            Console.WriteLine("* Заменяем все цифры на символ = " + targetChar);
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.ReplaceNumOnChar(str, targetChar);

            Console.WriteLine("Полученная строка: " + res);

            Console.ReadLine();
        }
    }
}
