using System;
using System.Collections.Generic;


class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int c = 0;
        foreach (string element in myDict.Keys)
            c++;
        return (c);
    }
}