using System;


class Array
{
    public static int elementAt(int[] array, int index)
    {
        int size = array.Length;
        if (index > size || index < 0)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
        else
        {
            int i = array[index];
            return i;
        }
    }
}
