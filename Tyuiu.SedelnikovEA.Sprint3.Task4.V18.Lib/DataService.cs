using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task4.V18.Lib
{
    public class DataService : ISprint3Task4V18
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                // При х == 0 прерываем выполнение цикла согласно условию
                if (x == 0)
                {
                    break;
                }

                // Вычисляем значение функции и добавляем к общей сумме
                sum += Math.Sin(x) / Math.Cos(x);
            }

            // Округляем результат до 3 знаков после запятой
            return Math.Round(sum, 3);
        }
    }
}
