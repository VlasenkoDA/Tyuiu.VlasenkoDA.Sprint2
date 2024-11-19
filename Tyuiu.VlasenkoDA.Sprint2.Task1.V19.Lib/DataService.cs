using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VlasenkoDA.Sprint2.Task1.V19.Lib
{
    public class DataService : ISprint2Task1V19
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            // 1. a != b — это условие даст True, так как 696 != 354
            bool result1 = a != b;

            // 2. a == c — это условие даст False, так как 696 != 423
            bool result2 = a == c;

            // 3. (b < c) | (d > a) — логическая операция ИЛИ
            // (354 < 423) | (957 > 696) → True | True → True
            bool result3 = (b < c) | (d > a);

            // 4. !(a > b) — логическая операция НЕ
            // !(696 > 354) → !(True) → False
            bool result4 = !(a > b);

            // 5. (c <= d) && (a != b) — логическая операция И
            // (423 <= 957) && (696 != 354) → True && True → True
            bool result5 = (c <= d) && (a != b);

            // 6. (a > b) ^ (c < d) — логическая операция XOR
            // (696 > 354) ^ (423 < 957) → True ^ True → False
            bool result6 = (a > b) ^ (c < d);

            // Возвращаем массив с результатами
            return new bool[] { result1, result2, result3, result4, result5, result6 };
        }
    }
}
