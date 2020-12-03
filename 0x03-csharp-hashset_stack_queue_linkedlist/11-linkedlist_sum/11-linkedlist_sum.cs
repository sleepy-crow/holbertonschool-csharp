using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int i = 0;
        foreach (int x in myLList)
            i += x;
        
        return i;
    }
}
