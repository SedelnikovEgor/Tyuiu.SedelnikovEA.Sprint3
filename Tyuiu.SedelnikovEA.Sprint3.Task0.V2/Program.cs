using System;
using Tyuiu.SedelnikovaEA.Sprint3.Task0.V2.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task0.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Формула: Произведение ((k / sin(1)^-7)^-2)                              *");

            int startValue = 1;
            int stopValue = 9;

            Console.WriteLine("* Старт шага = " + startValue);
            Console.WriteLine("* Конец шага = " + stopValue);
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetMultiplySeries(startValue, stopValue);

            Console.WriteLine("Произведение ряда равно: " + res);

            Console.ReadLine();
        }
    }
}
