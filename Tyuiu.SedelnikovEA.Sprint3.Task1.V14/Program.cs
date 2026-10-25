using System;
using Tyuiu.SedelnikovaEA.Sprint3.Task1.V14.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task1.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Формула: Сумма ((t^k + 1/(k+1)) * cos(t))                               *");

            double t = 0.7;
            int startValue = 1;
            int stopValue = 14;

            Console.WriteLine("* Переменная t = " + t);
            Console.WriteLine("* Старт шага = " + startValue);
            Console.WriteLine("* Конец шага = " + stopValue);
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSeries(t, startValue, stopValue);

            Console.WriteLine("Сумма ряда равна: " + res);

            Console.ReadLine();
        }
    }
}
