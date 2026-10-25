using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task0.V2.Lib
{
    public class DataService : ISprint3Task0V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiply = 1.0;

            for (int k = startValue; k <= stopValue; k++)
            {
                // Вычисляем внутреннюю часть: k / (sin(1) в степени -7)
                double internalValue = k / Math.Pow(Math.Sin(1), -7);

                // Возводим полученное значение в степень -2 и умножаем на общий результат
                multiply *= Math.Pow(internalValue, -2);
            }

            // Округляем результат до 3 знаков после запятой в соответствии с требованиями лабораторных работ
            return Math.Round(multiply, 3);
        }
    }
}