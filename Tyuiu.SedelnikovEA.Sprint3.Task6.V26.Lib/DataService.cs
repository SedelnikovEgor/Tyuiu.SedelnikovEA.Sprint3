using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task6.V26.Lib
{
    public class DataService : ISprint3Task6V26
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalDivisorsCount = 0;

            // Внешний цикл перебирает числа от 15 до 22
            for (int x = startValue; x <= stopValue; x++)
            {
                // Внутренний цикл ищет все делители текущего числа x
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        totalDivisorsCount++;
                    }
                }
            }

            return totalDivisorsCount;
        }
    }
}
