using System;
using System.Collections.Generic;


class List
{
    public static int Sum(List<int> myList)
    {
        int neo = 0, x = 0, y = 0;
        foreach (int e in myList)
        {
            y += 1;
            if (y > 1)
            {
                if (e == x)
                    continue;
                else
                    neo += e;
            }
            else
            {
                neo += e;
            }
            x = e;
        }
        return neo;
    }
}
