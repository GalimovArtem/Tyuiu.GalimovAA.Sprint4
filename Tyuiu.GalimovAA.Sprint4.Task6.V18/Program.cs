using System;
using Tyuiu.GalimovAA.Sprint4.Task6.V18.Lib;

namespace Tyuiu.GalimovAA.Sprint4.Task6.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Галимов А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Собака\", \"Кошка\", \"Кролик\",           *");
            Console.WriteLine("* \"Хомяк\", \"Попугай\", \"Рыбка\", \"Черепаха\"], используя класс Array,  *");
            Console.WriteLine("* выведите элементы массива, длина которых больше 6 символов.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] animals = { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"[{i}] = {animals[i]}");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] result = ds.Calculate(animals);

            Console.WriteLine("Элементы с длиной больше 6 символов:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"[{i}] = {result[i]}");
            }

            Console.ReadKey();
        }
    }
}