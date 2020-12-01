using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 97; i <= 122; i++)
            {
                if (i == 101 || i == 113)
                    i += 1;            
                char c = Convert.ToChar(i);
                Console.Write("{0}", c);
            }
        }
    }
}
