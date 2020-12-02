using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> myNewDict = new Dictionary<string, int>();
        foreach (string element in myDict.Keys)
            myNewDict[element] = myDict[element] * 2;

        return (myNewDict);
    }
}
