using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        public static int[] GetArray(int N)
        {
            int[] A = new int[N];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(0,1000);
            }
            ShowArray(A);
            return A;
        }

        public static void ShowArray(int[] A)
        {
            Console.Write("[");
            for (int i = 0; i < A.Length; i++)
            {
                if(i == A.Length-1) Console.Write(A[i]);
                else Console.Write(A[i] + "," + " ");
            }
            Console.WriteLine("]");
        }

        public static void SortMaxArray(int[] A)
        {
            int temp;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] < A[j])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }
            ShowArray(A);
        }

        public static void SortMinArray(int[] A)
        {
            int temp;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }
            ShowArray(A);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива N величиной от 0 до 20:");
            string input = Console.ReadLine();
            int N;
            bool isNum = int.TryParse(input, out N);
            if(isNum)
            {
                if (N > 0 && N < 20)
                {
                    int[] A = GetArray(N);
                    SortMaxArray(A);
                    SortMinArray(A);
                }
                else Console.WriteLine("Ошибка! Нужно ввести число от 0 до 20");
            }
            else Console.WriteLine("Ошибка! Введено не число!");
        }
    }
}
