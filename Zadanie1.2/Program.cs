using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        public static String[,] GetArray(int N, int M)
        {
            string[,] A = new string[N, M];
            int k = 0;
            for (int i = 0; i < N; i++)
            {
                if (i < N - 1)
                {
                    A[i, M / 2 - k] = "*";
                    A[i, M / 2 + k] = "*";
                    k++;
                }
                else
                {
                    for (int j = 0; j < M; j = j + 2)
                    {
                        A[i, j] = "*";
                    }
                }
            }
            ShowArray(A);
            return A;
        }

        public static void ShowArray(string[,] A)
        {
            int rows = A.GetUpperBound(0) + 1;
            int columns = A.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0,2}", A[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            int N, M;
            bool isNum = int.TryParse(input, out N);
            M = N * 2 - 1;
            if (isNum)
            {
                GetArray(N, M);
            }
            else Console.WriteLine("Ошибка! Введено не число!");
        }
    }
}
