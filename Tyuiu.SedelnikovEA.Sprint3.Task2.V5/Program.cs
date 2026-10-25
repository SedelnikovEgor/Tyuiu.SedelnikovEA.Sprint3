using System;
using Tyuiu.SedelnikovaEA.Sprint3.Task2.V5.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task2.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Формула: Сумма ((a^k + 1) * cos(k))                                     *");

            double a = 0.75;
            int startValue = 1;
            int stopValue = 20;

            Console.WriteLine("* Переменная a = " + a);
            Console.WriteLine("* Старт шага = " + startValue);
            Console.WriteLine("* Конец шага = " + stopValue);
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSeries(a, startValue, stopValue);

            Console.WriteLine("Сумма ряда равна: " + res);

            Console.ReadLine();
        }
    }
}
