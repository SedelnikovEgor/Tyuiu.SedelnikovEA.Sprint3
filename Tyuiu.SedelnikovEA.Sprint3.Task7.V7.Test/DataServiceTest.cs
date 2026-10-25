using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SedelnikovaEA.Sprint3.Task7.V7.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            // Математически ожидаемые значения для точек: -5, -4, -3, -2 (ошибка=0), -1, 0, 1, 2, 3, 4, 5
            double[] expected = new double[] { 15.09, 12.18, 8.65, 0.00, -2.46, 1.50, -2.28, -6.65, -10.12, -11.53, -14.47 };

            double[] res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}
