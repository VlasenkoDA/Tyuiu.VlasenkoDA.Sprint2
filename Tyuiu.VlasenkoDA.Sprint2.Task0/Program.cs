using System;
using Tyuiu.VlasenkoDA.Sprint2.Task0.V7.Lib;
namespace Tyuiu.VlasenkoDA.Sprint2.Task0.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 Выполнил: Власенко Д.А РППБ-24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                       *");
            Console.WriteLine("* Тема: Операции сравнения                                                        *");
            Console.WriteLine("* Задание # 0                                                                     *");
            Console.WriteLine("* Вариант # 7                                                                     *");
            Console.WriteLine("* Выполнил: Власенко Д.А РППБ-24-1                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Условие:                                                                        *");
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=,                " +
                "  *");
            Console.WriteLine("*последовательность операций не должна нарушаться) и арифметических выражений,    *");
            Console.WriteLine("*которая вернет логическую последовательность(массив):                            *");
            Console.WriteLine("(True, False, True, True, True, False), при x = 103, y = 475                      *");
            Console.WriteLine("***********************************************************************************");
            DataService dataService = new DataService();
            // Определяем значения x и y
            int x = 103;
            int y = 475;
            bool[] result = dataService.GetCompareOperations(x, y);
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Результат:                                                                      *");
            Console.WriteLine("***********************************************************************************");
            // Выводим результат на экран
            Console.WriteLine("Результат операций сравнения:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Операция {i + 1}: {result[i]}");
            }
            Console.WriteLine("***********************************************************************************");
            Console.ReadLine();
        }

    }
}
