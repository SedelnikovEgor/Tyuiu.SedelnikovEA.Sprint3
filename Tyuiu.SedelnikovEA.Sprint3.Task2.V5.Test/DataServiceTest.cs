using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SedelnikovaEA.Sprint3.Task2.V5.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double a = 0.75;
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetSumSeries(a, startValue, stopValue);

            double expected = -0.669;

            Assert.AreEqual(expected, res);
        }
    }
}
