using System;
using Tyuiu.GalimovAA.Sprint4.Task0.V8.Lib;

namespace Tyuiu.GalimovAA.Sprint4.Task0.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Галимов А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать произведение *");
            Console.WriteLine("* четных элементов массива. (1,6,3,7,5,4,2,7,8,9)                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };

            Console.WriteLine("Массив: {1, 6, 3, 7, 5, 4, 2, 7, 8, 9}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetMultEvenArrEl(array);
            Console.WriteLine("Произведение четных элементов массива = " + result);

            Console.ReadKey();
        }
    }
}