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
            Console.WriteLine("Введите целое число, не меньше нуля. Чтобы выйти из программы - напишите 'выход'.");
            string result = Console.ReadLine();// результат ввода пользователем.

            if (result == "выход")
            {
                Environment.Exit(0);
            }

            int cubeSize = Convert.ToInt32(result);// переменная означает размер сторон куба 
            char[][][] nums = GetTheCube(cubeSize);

            for (int i = 0; i < cubeSize; ++i)
            {
                Console.WriteLine($"Срез {i + 1}");

                for (int j = 0; j < cubeSize; ++j)
                {

                    for (int k = 0; k < cubeSize; ++k)
                    {
                        Console.Write(nums[i][j][k]);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }
        /// <summary>
        /// Метод возвращает заполненный массив, символом X
        /// </summary>
        /// <param name="cubeSize"></param>
        /// <returns>Заполненный зубчатый массив</returns>
        static char[][][] GetTheCube(int cubeSize)
        {

            if (cubeSize < 0)
            {
                Console.WriteLine("Ошибка. Неверно введён аргумент.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            char symbol = 'X';
            char[][][] nums = new char[cubeSize][][];

            for (int a = 0; a < cubeSize; ++a)
            {
                nums[a] = new char[cubeSize][];

                if (a == 0 || a == nums[a].Length - 1)
                {
                    for (int b = 0; b < nums[a].Length; ++b)
                    {
                        nums[a][b] = new char[cubeSize];

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
                    for (int d = 0; d < cubeSize; ++d)
                    {
                        nums[a][d] = new char[cubeSize];

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
