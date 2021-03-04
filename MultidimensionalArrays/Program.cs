using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 3;
            int[,] nums;
            SampleMethod(N);
            int rows = nums.GetUpperBound(0) + 1;
            int columns = nums.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{nums[i, j]}");
                    if (j < columns - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static int[,] SampleMethod(int N)
        {
            if (N == null)
            {
                Console.WriteLine("Ошибка. Аргумент N не может быть null.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (N <= 0)

            {
                Console.WriteLine("Ошибка. Аргумент N не может быть меньше или равен нулю.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            int[,] nums = new int[N, N];
            int elementСounter = 1; //данная переменная будет давать значения элементам в массиве

            for (int a = 0; a < N; ++a)
            {
                for (int b = 0; b < N; ++b)
                {
                    nums[a, b] = elementСounter;
                    ++elementСounter;
                }
            }
            return new int[N, N];
        }
           
        }
    }

