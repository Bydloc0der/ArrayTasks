using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 13;
            char X = 'X'; 
            char space = ' ';
            char[,] array = MadeSpiral(N,X,space);
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            for (int c = 0; c < rows; c++)
            {
                for (int d = 0; d < columns; d++)
                {
                    Console.Write($"{array[c, d]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Метод возвращает двухмерный массив символов, выстраивающих сприраль.
        /// </summary>
        /// <param name="N">Число, обозначающее размер массива</param>
        /// <param name="X">Символ, который будет "стенкой" спирали</param>
        /// <param name="space"> Символ, который будет "пустотой" в спирали</param>
        /// <returns></returns>

        static char[,] MadeSpiral (int N, char X, char space)
        {
            if (0 == N % 2 || N < 5)
            {
                Console.WriteLine("Ошибка. Аргумент N не может быть меньше 5 и чётным.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            char[,] array = new char[N, N];
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int s = N - 1;

            for (int a = 0; a < N+1/2; ++a)
            {
                char mark;
                if (a % 2 == 0)
                {
                    mark = X;
                }
                else
                {
                    mark = space;
                }
                    
                int counter = 0;

                while (counter + a < N - a)
                {
                    array[a, a + counter] = mark;
                    array[a + counter, a] = mark;

                    array[s, s - counter] = mark;
                    array[s - counter, s] = mark;

                    ++counter;
                }
                --s;
            }

            for (int c = 0; c < N / 2; ++c)
            {
                if (array[c + 1, c] == X)
                {
                    array[c + 1, c] = space;
                }
                else
                {
                    array[c + 1, c] = X;
                }
            }

            return array;
        }
    }
}
