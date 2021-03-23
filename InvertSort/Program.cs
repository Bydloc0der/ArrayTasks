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
            int[,] nums = { { 250, 500,750,1000}, { 1250,1500,1750,2000}, { 2250,2500,2750,3000 }, { 3250, 3500,3750,4000 } };
            int[,] numz = Invert(nums);
            int rows = numz.GetUpperBound(0) + 1;
            int columns = numz.Length / rows;
            for (int a = 0; a < rows; a++)
            {
                for (int b = 0; b < columns; b++)
                {
                    Console.Write($"{numz[a, b]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
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
            int swap = 0; // переменная будет заменять элементы в массиве
            int numberOfElementInRow = 0; // переменная указывает номер элемента в ряду

            for (int a = rows-1; a > 0; --a)
            {
                int counter = 1;// переменная позволяет отсчитывать расстояние между элементами, которые будут меняться, при помощи переменной "swap"
                while (a - counter >= 0)
                {
                    swap = nums[a - counter, numberOfElementInRow];
                    nums[a - counter, numberOfElementInRow] = nums[a , numberOfElementInRow + counter];
                    nums[a , numberOfElementInRow + counter] = swap;
                    ++counter;
                }
                ++numberOfElementInRow;
            }
            return nums;
        }
    }
}
