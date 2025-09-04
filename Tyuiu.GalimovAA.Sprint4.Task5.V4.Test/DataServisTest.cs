using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint4.Task5.V4.Lib;

namespace Tyuiu.GalimovAA.Sprint4.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                { 1, -2, 3, -4, 5 },
                { -1, 2, -3, 4, -4 },
                { 6, 0, -2, 3, 1 },
                { -3, 2, 4, -1, 2 },
                { 5, -4, 3, 2, 1 }
            };

            int result = ds.Calculate(matrix);
            int wait = 14;

            Assert.AreEqual(wait, result);
        }
    }
}