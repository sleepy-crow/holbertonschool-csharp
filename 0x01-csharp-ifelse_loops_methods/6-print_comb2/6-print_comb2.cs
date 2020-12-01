using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 1;
            for (; i <= 9; j++)
            {
                if (j > 9)
                {
                    i += 1;
                    j = i + 1;
                }
                if (i == 8)
                {
                    Console.Write("{0:D}{1:D}\n", i, j);
                    break;
                }
                Console.Write("{0:D}{1:D}, ", i, j);
            }
        }
    }
}
