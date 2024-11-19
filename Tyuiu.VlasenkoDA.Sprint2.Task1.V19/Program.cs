using System;
using Tyuiu.VlasenkoDA.Sprint2.Task1.V19.Lib;
namespace Tyuiu.VlasenkoDA.Sprint2.Task1.V19
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "Спринт #1 Выполнил: Власенко Д.А РППБ-24-1";
            Console.WriteLine("***********************************************************************************" );
            Console.WriteLine("* Спринт #2                                                                        *");
            Console.WriteLine("* Тема: Логические операции                                                        *");
            Console.WriteLine("* Задание # 1                                                                      *");
            Console.WriteLine("* Вариант # 19                                                                     *");
            Console.WriteLine("* Выполнил: Власенко Д.А РППБ-24-1                                                 *");
            Console.WriteLine("***********************************************************************************" );
            Console.WriteLine("* Условие:                                                                         *");
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность*");
            Console.WriteLine("*можно чередовать, но использовать один раз в выражении) и логических операций     *");
            Console.WriteLine("*(|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также   *");
            Console.WriteLine("(арифметических выражений, которая вернет логическую последовательность(массив):   *");
            Console.WriteLine("((True, False, True, False, True, False), при a = 696, b = 354, c = 423, d = 957   *");
            Console.WriteLine("***********************************************************************************");
            // Заданные значения
            int a = 696;
            int b = 354;
            int c = 423;
            int d = 957;

            // Создаем объект класса DataService
            var dataService = new DataService();

            // Получаем результаты логических операций
            bool[] results = dataService.GetLogicOperations(a, b, c, d);
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Результат:                                                                      *");
            Console.WriteLine("***********************************************************************************");
            // Выводим результаты
            Console.WriteLine("Результаты логических выражений:");
            foreach (bool result in results)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine("***********************************************************************************");
            Console.ReadLine();

           
        }
    }
}
