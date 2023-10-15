using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PolyanskiyDE.Sprint2.Task5.V6.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Дама треф", ds.FindCardNameAndValue(2, 12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(0, 5);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(5, 15);
            });
        }
    }
}
