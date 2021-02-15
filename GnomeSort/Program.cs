using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnomeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 7, 8, 3, 1, 0, 9, 2, 6 };
            GnomeSort(nums);
        }

        static void GnomeSort(int[] nums)
        {
            if (nums == null)
            {
                Console.WriteLine("Ошибка. Аргумент nums не может быть null.");
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

            for (int a = 1; a < nums.Length; ++a)
            {
                if (nums[a] < nums[a - 1])
                {
                    swap = nums[a];
                    nums[a] = nums[a-1];
                    nums[a - 1] = swap;
                    --a;
                    if (a >= 1)
                    {
                        --a;
                    }
                    continue;
                }
            }
        }
    }
}
