using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint4.Task2.V4.Lib;

namespace Tyuiu.GalimovAA.Sprint4.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5, 6 };
            int result = ds.Calculate(array);
            int wait = 32;

            Assert.AreEqual(wait, result);
        }
    }
}