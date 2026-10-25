using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task5.V6.Lib
{
    public class DataService : ISprint3Task5V6
    {
        public double GetSumSumSeries(int startValue1, int stopValue1, int startValue2, int stopValue2)
        {
            double sum = 0;

            // Внешний цикл по переменной i (от 1 до 3)
            for (int i = startValue1; i <= stopValue1; i++)
            {
                // Внутренний цикл по переменной k (от 1 до 10)
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    // Скобки гарантируют, что + 2.0 прибавляется К РЕЗУЛЬТАТУ деления, 
                    // а не к косинусу в знаменателе
                    sum += (1.0 / Math.Cos(k)) + 2.0;
                }
            }

            // Округляем результат до 3 знаков после запятой
            return Math.Round(sum, 3);
        }
    }
}
