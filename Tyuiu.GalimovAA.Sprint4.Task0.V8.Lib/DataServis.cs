using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GalimovAA.Sprint4.Task0.V8.Lib
{
    public class DataService : ISprint4Task0V8
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int product = 1;
            bool hasEven = false;

            foreach (int num in array)
            {
                if (num % 2 == 0 && num != 0)
                {
                    product *= num;
                    hasEven = true;
                }
            }

            return hasEven ? product : 0;
        }
    }
}