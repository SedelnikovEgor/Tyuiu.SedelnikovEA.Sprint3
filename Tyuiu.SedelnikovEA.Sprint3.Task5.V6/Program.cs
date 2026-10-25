using System;
using Tyuiu.SedelnikovaEA.Sprint3.Task5.V6.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Формула: Двойная сумма (1 / cos(k) + 2)                                 *");

            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine("* Старт шага 1 (i) = " + startValue1);
            Console.WriteLine("* Конец шага 1 (i) = " + stopValue1);
            Console.WriteLine("* Старт шага 2 (k) = " + startValue2);
            Console.WriteLine("* Конец шага 2 (k) = " + stopValue2);
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSumSeries(startValue1, stopValue1, startValue2, stopValue2);

            Console.WriteLine("Сумма двойного ряда равна: " + res);

            Console.ReadLine();
        }
    }
}
