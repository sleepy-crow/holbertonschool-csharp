using System;


class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> list = new List<int>();

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        if (size == 0)
        {
            Console.WriteLine();
        }

        for (int i = 0; i < size; i++)
        {
            if (i < size - 1)
                Console.Write(i + " ");
            else
                Console.WriteLine(i);
            list.Add(i);
        }

        return list;

    }
}
