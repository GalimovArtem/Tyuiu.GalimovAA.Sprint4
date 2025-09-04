using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GalimovAA.Sprint4.Task7.V12.Lib
{
    public class DataService : ISprint4Task7V12
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int index = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int number = int.Parse(value[index].ToString());
                    matrix[i, j] = number;

                    if (number % 2 != 0)
                    {
                        sum += number;
                    }

                    index++;
                }
            }

            return sum;
        }
    }
}