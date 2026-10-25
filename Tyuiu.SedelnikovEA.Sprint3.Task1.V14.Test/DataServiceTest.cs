using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SedelnikovaEA.Sprint3.Task1.V14.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double t = 0.7;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetSumSeries(t, startValue, stopValue);

            double expected = 3.546;

            Assert.AreEqual(expected, res);
        }
    }
}
