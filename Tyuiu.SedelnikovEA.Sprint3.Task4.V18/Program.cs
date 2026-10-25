using System;
using Tyuiu.SedelnikovaEA.Sprint3.Task4.V18.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task4.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Функция: y = sin(x) / cos(x)                                            *");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("* Старт шага = " + startValue);
            Console.WriteLine("* Конец шага = " + stopValue);
            Console.WriteLine("* При x = 0 цикл прерывается.                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(startValue, stopValue);

            Console.WriteLine("Сумма значений функции равна: " + res);

            Console.ReadLine();
        }
    }
}
