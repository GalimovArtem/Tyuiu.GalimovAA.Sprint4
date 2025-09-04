﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GalimovAA.Sprint4.Task2.V4.Lib
{
    public class DataService : ISprint4Task2V4
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                if (num % 2 != 0) 
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}