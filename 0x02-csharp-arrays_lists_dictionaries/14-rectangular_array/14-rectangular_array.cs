using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int j = 5;

            int[,] rabbitHole = new int[i, j];

            rabbitHole[2, 2] = 1;
            for (int w = 0; w < i; w++)
            {
                for (int h = 0; h < j; h++)
                {
                    Console.Write(rabbitHole[w, h]);
                    if (h < j - 1)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
