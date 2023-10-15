using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PolyanskiyDE.Sprint2.Task4.V30.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint2.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 343;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}
