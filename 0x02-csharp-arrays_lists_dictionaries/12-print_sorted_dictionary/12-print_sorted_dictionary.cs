using System;
using System.Collections.Generic;


class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> sorted_dict = new List<string>(myDict.Keys);
        sorted_dict.Sort();
        foreach (string element in sorted_dict)
            Console.WriteLine(element + ": " + myDict[element]);
    }
}
