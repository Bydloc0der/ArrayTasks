using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 2, 7, 1, 5, 9, 3 };
            StupidSorting(nums);
        }

        static void StupidSorting(int[] nums)
        {
            if (nums == null)
            {
                Console.WriteLine("Ошибка. null - не является аргументом.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (nums.Length <= 0)
            {
                Console.WriteLine("Ошибка. В массиве отсутствуют элементы.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            for (int a = 1; a < nums.Length; ++a)
            {
                int swap = 0; // данная переменая будет менять местами элементы массива.
                if (nums[a] < nums[a - 1])
                {
                    swap = nums[a - 1];
                    nums[a - 1] = nums[a];
                    nums[a] = swap;
                    a = 0;
                }

            }
        }
    }
}
