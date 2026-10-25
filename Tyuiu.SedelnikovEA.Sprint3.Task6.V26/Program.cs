using System;
using Tyuiu.SedelnikovaEA.Sprint3.Task6.V26.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task6.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 15;
            int stopValue = 22;

            Console.WriteLine("* Найти количество всех делителей на отрезке целых чисел [" + startValue + ", " + stopValue + "]");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("Количество всех делителей равно: " + res);

            Console.ReadLine();
        }
    }
}
