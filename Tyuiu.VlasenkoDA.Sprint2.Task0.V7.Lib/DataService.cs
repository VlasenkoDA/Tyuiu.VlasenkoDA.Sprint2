using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VlasenkoDA.Sprint2.Task0.V7.Lib
{
    public class DataService : ISprint2Task0V7
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            // Создаем массив логических значений для сравнения
            return new bool[]
            {
                x == y,    // Сравнение на равенство
                x != y,    // Сравнение на неравенство
                x < y,     // Сравнение на меньше
                x > y,     // Сравнение на больше
                x <= y,    // Сравнение на меньше или равно
                x >= y     // Сравнение на больше или равно
            };
        }
    }
}
