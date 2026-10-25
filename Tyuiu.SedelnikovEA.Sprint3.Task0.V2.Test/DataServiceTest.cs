using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SedelnikovaEA.Sprint3.Task0.V2.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 9;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double expected = 0.0;

            Assert.AreEqual(expected, res);
        }
    }
}
