using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0;i < 99; i++){
                string hex = i.ToString("X");
                Console.Write("{0:D} = {1}\n", i, hex);
            }
        }
    }
}
