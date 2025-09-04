using System;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GalimovAA.Sprint4.Task6.V18.Lib
{
    public class DataService : ISprint4Task6V18
    {
        public string[] Calculate(string[] array)
        {
            return Array.FindAll(array, x => x.Length > 6);
        }
    }
}