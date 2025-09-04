using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint4.Task0.V8.Lib;

namespace Tyuiu.GalimovAA.Sprint4.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            int wait = 6 * 4 * 2 * 8; // 384

            int res = ds.GetMultEvenArrEl(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetMultEvenArrEl_NoEven()
        {
            DataService ds = new DataService();

            int[] array = { 1, 3, 5, 7, 9, 1, 3, 5, 7, 9 };
            int wait = 0;

            int res = ds.GetMultEvenArrEl(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetMultEvenArrEl_WithZero()
        {
            DataService ds = new DataService();

            int[] array = { 0, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
            int wait = 2 * 4 * 6 * 8; // 384

            int res = ds.GetMultEvenArrEl(array);

            Assert.AreEqual(wait, res);
        }
    }
}