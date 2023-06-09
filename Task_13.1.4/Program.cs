﻿namespace Task_13._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckAscending(new[] { -1, 2, 3, 4, 8 }));

            Console.WriteLine(CheckAscending(new[] { -1, 2, 3, 10, 8 }));
        }
        static bool CheckAscending(int[] numbers)
        {
            //  используем цикл for для обхода массива
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                //  проверяем следующий элемент на предмет того, что он меньше предыдушего
                if (numbers[i + 1] < numbers[i])
                    return false;
            }
            return true;
        }
    }
}