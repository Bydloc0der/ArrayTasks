using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            int[,] invertNums = Invert(nums);
            int rows = invertNums.GetUpperBound(0) + 1;
            int columns = invertNums.Length / rows;

            for (int a = 0; a < rows; a++)
            {
                for (int b = 0; b < columns; b++)
                {
                    Console.Write($"{invertNums[a, b]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Метод возвращает новый массив, с инвертированным порядком элементов заложенного массива
        /// </summary>
        /// <param name="nums">массив</param>
        /// <returns> Инвертированный массив</returns>
        static int[,] Invert(int[,] nums)
        {
            int rows = nums.GetUpperBound(0) + 1;
            int columns = nums.GetUpperBound(1) + 1;

            if (rows != columns)
            {
                Console.WriteLine("Ошибка. Количество элементов и массивов не совпадает. Нужен равносторонний двумерный массив");
                Console.ReadKey();
                Environment.Exit(0);
            }

            int[,] invertNums = new int[rows, columns];

            for (int s = 0; s < rows; ++s)
            {
                for (int d = 0; d < columns; ++d)
                {
                    invertNums[s, d] = nums[s, d];
                }
            }

            int swap = 0; // переменная будет заменять элементы в массиве
            int numberOfElementInRow = 0; // переменная указывает номер элемента в ряду

            for (int a = rows - 1; a > 0; --a)
            {
                int counter = 1;// переменная позволяет отсчитывать расстояние между элементами, которые будут меняться, при помощи переменной "swap"

                while (a - counter >= 0)
                {
                    swap = invertNums[a - counter, numberOfElementInRow];
                    invertNums[a - counter, numberOfElementInRow] = invertNums[a, numberOfElementInRow + counter];
                    invertNums[a, numberOfElementInRow + counter] = swap;
                    ++counter;
                }

                ++numberOfElementInRow;
            }

            return invertNums;
        }
    }
}
