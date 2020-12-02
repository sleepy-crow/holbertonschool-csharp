using System;


class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        List<int> intList = new List<int>();

        for (int i = 0; i < size; i++)
        {
            intList.Add(i);
            if (i < size - 1)
                Console.Write(i + " ");
            else
                Console.Write(i);
        }
        Console.WriteLine();
        return (intList);

    }
}
