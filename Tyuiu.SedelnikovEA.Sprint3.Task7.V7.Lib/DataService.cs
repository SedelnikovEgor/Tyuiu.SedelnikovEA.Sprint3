using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task7.V7.Lib
{
    public class DataService : ISprint3Task7V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Вычисляем размер массива. Для диапазона [-5; 5] это 5 - (-5) + 1 = 11 элементов
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверка деления на ноль: знаменатель x + 2 равен 0 при x = -2
                if (x + 2 == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    // Вычисляем значение функции F(x) = cos(x) + cos(x)/(x+2) - 3x
                    double res = Math.Cos(x) + (Math.Cos(x) / (x + 2)) - (3.0 * x);
                    valueArray[count] = Math.Round(res, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}
