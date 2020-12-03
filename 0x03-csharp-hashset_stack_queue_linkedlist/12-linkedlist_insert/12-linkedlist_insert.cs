using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        if (n < myLList.First.Value)
            myLList.AddFirst(n);

        else if (n > myLList.Last.Value)
            myLList.AddLast(n);

        else
        {
            foreach (int e in myLList)
            {
                if (e > n)
                {
                    myLList.AddBefore(myLList.Find(e), n);
                    break;
                }
            }
        }
        return (myLList.Find(n));
    }
}
