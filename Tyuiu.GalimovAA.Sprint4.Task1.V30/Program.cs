using System;
using Tyuiu.GalimovAA.Sprint4.Task1.V30.Lib;

namespace Tyuiu.GalimovAA.Sprint4.Task1.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Галимов А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 5 до 9.             *");
            Console.WriteLine("* Подсчитать произведение четных элементов массива.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[15];
            Console.WriteLine("Введите 15 элементов массива (целые числа от 5 до 9):");

            for (int i = 0; i < 15; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

                // Проверка диапазона
                while (array[i] < 5 || array[i] > 9)
                {
                    Console.Write("Ошибка! Введите число от 5 до 9: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Введенный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine($"Произведение четных элементов массива = {result}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ АВТОТЕСТА:                                                    *");
            Console.WriteLine("***************************************************************************");

            // Автотест с заданными значениями
            int[] testArray = { 6, 7, 8, 7, 6, 5, 6, 9, 9, 5, 7, 9, 7, 8, 7 };
            int testResult = ds.Calculate(testArray);
            Console.WriteLine($"Тестовый массив: {string.Join(", ", testArray)}");
            Console.WriteLine($"Результат для тестовых данных = {testResult}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ВЫПОЛНИЛ: Галимов Артём Азатович | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}