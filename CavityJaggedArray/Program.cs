using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavityJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 29;
            char[][] array = MadeCavity(N);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Метод возвращает заполненный символами зубчатый массив
        /// </summary>
        /// <param name="N"></param>
        /// <returns>Заполненный зубчатый массив</returns>
        static char[][] MadeCavity(int N)
        {
            if (N < 3)
            {
                Console.WriteLine("Ошибка. Аргумент N должен быть больше или равен 3.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            char symbol = 'Z';//Символ, который будет отображать впадину.
            char[][] nums = new char[N][];// зубчатый массив
            int lenght = N / 2;// длина самого верхнего и нижнего массива
            if (N % 2 != 0)
            {
                lenght += 1;
            }

            int counter = 0;// переменная, которая будет помогать уменьшать длинну нижних массивов, для создания впадины

            for (int a = 0; a < lenght; ++a)
            {
                nums[a] = new char[lenght - a];

                for (int c = 0; c < nums[a].Length; ++c)
                {
                    nums[a][c] = symbol;
                }
            }

            for (int d = N - 1; d >= lenght; --d)
            {
                nums[d] = new char[lenght - counter];

                for (int e = 0; e < nums[d].Length; ++e)
                {
                    nums[d][e] = symbol;
                }
                ++counter;
            }

            return nums;
        }
    }
}
