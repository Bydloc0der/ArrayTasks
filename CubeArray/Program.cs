using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число, не меньше 3-ёх.");
            int N = Convert.ToInt32(Console.ReadLine());
            
            char[][][] nums = GetTheCube(N);
             
                for (int i = 0; i < N; ++i)
                {
                    Console.WriteLine($"Срез {i+1}");

                    for (int j = 0; j < N; ++j)
                    {

                        for (int k = 0; k < N; ++k)
                        {
                            Console.Write(nums[i][j][k]);
                        }

                        Console.WriteLine();
                    }

                    Console.WriteLine();
                }

            Console.ReadKey();

        }

        static char[][][] GetTheCube(int N)
        {

            if (N < 3)
            {
                Console.WriteLine("Ошибка. Неверно введён аргумент.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            char symbol = 'X';
            char[][][] nums = new char[N][][];

            for (int a = 0; a < N; ++a)
            {
                nums[a] = new char[N][];

                if (a == 0 || a == nums[a].Length - 1)
                {
                    for (int b = 0; b < nums[a].Length; ++b)
                    {
                        nums[a][b] = new char[N];

                        for (int c = 0; c < nums[a][b].Length; ++c)
                        {

                            if (b == 0 || b == nums[a][b].Length - 1)
                            {
                                nums[a][b][c] = symbol;
                            }
                            else
                            {
                                if (c == 0 || c == nums[a][b].Length - 1)
                                {
                                    nums[a][b][c] = symbol;
                                }
                            }
                        }
                    }
                }

                else
                {
                    for (int d = 0; d < N;++d)
                    {
                        nums[a][d] = new char[N];
                        if (d == 0 || d == nums[a][d].Length - 1)
                        {
                            nums[a][d][d] = symbol;
                            nums[a][0][d] = symbol;
                            nums[a][d][0] = symbol;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }

            return nums;
        }
    }
}
