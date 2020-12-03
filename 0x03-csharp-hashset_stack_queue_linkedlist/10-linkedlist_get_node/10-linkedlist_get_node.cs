using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int i = 0;
        foreach (int x in myLList)
        {
            if (i == n)
                return x;
            i++;
        }
        if (i < n)
            return 0;
        return -1;

    }
}
