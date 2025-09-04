using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint4.Task1.V30.Lib;

namespace Tyuiu.GalimovAA.Sprint4.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 6, 7, 8, 7, 6, 5, 6, 9, 9, 5, 7, 9, 7, 8, 7 };

            int result = ds.Calculate(array);
            int wait = 6 * 8 * 6 * 6 * 8; 

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void NoEvenElementsTest()
        {
            DataService ds = new DataService();

            int[] array = { 5, 7, 9, 7, 5, 7, 9, 7, 5, 7, 9, 7, 5, 7, 9 }; // Все нечетные

            int result = ds.Calculate(array);
            int wait = 0;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void AllEvenElementsTest()
        {
            DataService ds = new DataService();

            int[] array = { 6, 8, 6, 8, 6, 8, 6, 8, 6, 8, 6, 8, 6, 8, 6 }; // Все четные

            int result = ds.Calculate(array);
            int wait = 6 * 8 * 6 * 8 * 6 * 8 * 6 * 8 * 6 * 8 * 6 * 8 * 6 * 8 * 6;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void SingleEvenElementTest()
        {
            DataService ds = new DataService();

            int[] array = { 5, 7, 9, 7, 5, 7, 9, 7, 6, 7, 9, 7, 5, 7, 9 }; // Один четный элемент

            int result = ds.Calculate(array);
            int wait = 6;

            Assert.AreEqual(wait, result);
        }
    }
}