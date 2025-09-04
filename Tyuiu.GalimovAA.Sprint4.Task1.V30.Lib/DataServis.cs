using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GalimovAA.Sprint4.Task1.V30.Lib
{
    public class DataService : ISprint4Task1V30
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasEven = false;

            foreach (int num in array)
            {
                if (num % 2 == 0) // Проверяем четность
                {
                    product *= num;
                    hasEven = true;
                }
            }

            if (!hasEven)
            {
                return 0; // Если нет четных элементов, возвращаем 0
            }

            return product;
        }
    }
}