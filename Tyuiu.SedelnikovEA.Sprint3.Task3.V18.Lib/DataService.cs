using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char replaceable)
        {
            string result = "";

            // Используем обязательный цикл foreach для посимвольного перебора строки
            foreach (char chr in value)
            {
                // Если текущий символ является цифрой, добавляем в результат переданный символ replaceable ('n')
                if (char.IsDigit(chr))
                {
                    result += replaceable;
                }
                else
                {
                    result += chr;
                }
            }

            return result;
        }
    }
}
