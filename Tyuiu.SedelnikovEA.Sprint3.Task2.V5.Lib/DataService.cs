using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task2.V5.Lib
{
    public class DataService : ISprint3Task2V5
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;

            // Используем цикл do...while согласно условию задания
            do
            {
                sum += (Math.Pow(value, k) + 1.0) * Math.Cos(k);
                k++;
            } while (k <= stopValue);

            // Округляем до 3 знаков после запятой по стандарту лабораторных работ
            return Math.Round(sum, 3);
        }
    }
}
