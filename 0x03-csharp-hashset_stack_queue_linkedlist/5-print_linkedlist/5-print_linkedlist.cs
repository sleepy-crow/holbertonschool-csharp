using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> intLinkd = new LinkedList<int>();

        if (size < 0)
            return (intLinkd);

        for (int i= 0; i < size; i++)
         {
             Console.WriteLine(i);
             intLinkd.AddLast(i);
         }   
        
        return(intLinkd);
    }
}
