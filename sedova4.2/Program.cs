using System;

namespace sedova4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mas[i, j] = 0;
                }
            }
            int n = 5 / 2;
            mas[n,n] = 1;
            mas[n, n - 1] = 1;
            mas[n, n - 2] = 1;
            mas[n, n + 1] = 1;
            mas[n, n + 2] = 1;
            mas[n + 1, n] = 1;
            mas[n + 2, n] = 1;
            mas[n - 1, n] = 1;
            mas[n - 2, n] = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
