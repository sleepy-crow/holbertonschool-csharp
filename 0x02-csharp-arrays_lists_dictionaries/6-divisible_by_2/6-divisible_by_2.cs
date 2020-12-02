using System;
using System.Collections.Generic;


class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> divisible = new List<bool>();
        foreach (int element in myList)
        {
            if (element % 2 == 0)
                divisible.Add(true);
            else
                divisible.Add(false);
        }
        return (divisible);
    }
}
