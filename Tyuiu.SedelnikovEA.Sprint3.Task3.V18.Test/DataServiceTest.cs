using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SedelnikovaEA.Sprint3.Task3.V18.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint3.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();

            string str = "4n5nvf 56 bgy";
            char targetChar = 'n';

            string res = ds.ReplaceNumOnChar(str, targetChar);

            string expected = "nnnnvf nn bgy";

            Assert.AreEqual(expected, res);
        }
    }
}
