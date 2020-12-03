using System;
using System.Collections.Generic;


class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> notGlitched = new List<int>();

        foreach (int i in list1)
        {
            if (!list2.Contains(i))
                notGlitched.Add(i);
        }

        foreach (int j in list2)
        {
            if (!list1.Contains(j))
                notGlitched.Add(j);
        }

        notGlitched.Sort();

        return notGlitched;
    }
}
