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
            for (int f = 0; f < 1;)
            {
                string result = Console.ReadLine();// результат ввода пользователем.
                int cubeSize; // размер куба
                bool checkNumber = int.TryParse(result, out cubeSize);

                if (result == "выход")
                {
                    Environment.Exit(0);
                }
                else if (checkNumber == true)
                {
                    char[][][] nums = GetTheCube(cubeSize);
                    GetResultOnScreen(nums, cubeSize);
                    ++f;
                }
                else
                {
                    Console.WriteLine("Ошибка. Введены не верные данные. Введите целое число, не меньше нуля. Чтобы выйти из программы - напишите 'выход'.  ");
                }
            }
        }
        /// <summary>
        /// Метод возвращает заполненный массив, символом X
        /// </summary>
        /// <param name="cubeSize"></param>
        /// <returns>Заполненный зубчатый массив</returns>
        static char[][][] GetTheCube(int cubeSize)
        {

            if (cubeSize < 1)
            {
                Console.WriteLine("Ошибка. Введены не верные данные");
                Console.ReadKey();
                Environment.Exit(0);
            }

            char symbol = 'X';// ссимвол, отображающий грани куба
            char space = ' ';// символ, отвечающий за пустое пространство, при вывроде на экран
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
                            else if (c == 0 || c == nums[a][b].Length - 1)
                            {
                                nums[a][b][c] = symbol;
                            }
                            else
                            {
                                nums[a][b][c] = space;
                            }
                        }
                    }
                }
                else
                {
                    for (int d = 0; d < cubeSize; ++d)
                    {
                        nums[a][d] = new char[cubeSize];
                        for (int e = 0; e < cubeSize; ++e)
                        {
                            if ((d == 0 || d == nums[a][d].Length - 1) && (e == 0 || e == nums[a][d].Length - 1))
                            {
                                nums[a][d][d] = symbol;
                                nums[a][0][d] = symbol;
                                nums[a][d][0] = symbol;
                            }
                            else
                            {
                                nums[a][d][e] = space;
                            }
                        }
                    }
                }
            }

            return nums;
        }
        /// <summary>
        /// Метод вывдоит результат на экран (срез куба)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="cubeSize"></param>
        static void GetResultOnScreen(char[][][] nums, int cubeSize)
        {
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
    }
}
