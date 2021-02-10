using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AscendingNumbersByBubbleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 1, 2, 5, 7, 6, 8, 9, 3 };
            SortAscending(nums);
        }

        static int[] SortAscending(int[] nums)
        {
            if (nums == null)
            {
                Console.WriteLine("Введены не верные данные. В массиве отсуствуют числа"); 
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (nums.Length <= 0)
            {
                Console.WriteLine("Ошибка. В массиве отсутствуют элементы.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            int swap = 0; // данная переменая будет менять местами элементы массива.
            int holdLastElement = 1; // данная переменная позволяет обрабатывать на 1 элемент меньше, при сортировке массива.
            for (int a = 0; a < nums.Length; ++a)
            {
                
                for (int b = 0; b < nums.Length - holdLastElement; ++b)
                {
                    if (nums[b] > nums[b + 1])
                    {
                        swap = nums[b];
                        nums[b] = nums[b + 1];
                        nums[b + 1] = swap;
                    }
                    else
                    {
                        continue;
                    }
                }
                ++holdLastElement;
            }

            return  nums;         
        }
    }
}
