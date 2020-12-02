using System;


class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size > 0)
        {
            int i, j;
            int[] array = new int[size];
            for (i = 0; i < size; i++)
            {
                array[i] = i;
            }
            for (j = 0; j < size; j++)
            {
                if (j != size - 1)
                    Console.Write(array[j] + " ");
                else
                    Console.Write(array[j] + "\n");
            }
            return array;
        }
        else if (size == 0)
        {
            int[] array = new int[size];
            Console.WriteLine("");
            return array;
        }
        else
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
    }
}
