using System;
using Tyuiu.SedelnikovaEA.Sprint3.Task7.V7.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Функция: F(x) = cos(x) + cos(x)/(x+2) - 3x                              *");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("* Старт шага = " + startValue);
            Console.WriteLine("* Конец шага = " + stopValue);
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                // Выводим таблицу значений с красивым форматированием строк
                Console.WriteLine("| {0,5}    |  {1,6}  |", x, valueArray[count]);
                count++;
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadLine();
        }
    }
}
