using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        if (aQueue.Count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine("First item: {0}", aQueue.Peek());
        
        if (newItem != null)
            aQueue.Enqueue(newItem);
        
        bool contains = aQueue.Contains(search);
        
        Console.WriteLine("Queue contains \"{0}\": {1}", search, contains);

        Queue<string> neoQueue = new Queue<string>(aQueue);

        if (aQueue.Contains(search))
            foreach (var item in neoQueue)
            {
                if (aQueue.Dequeue() == search)
                    break;
            }


        return aQueue;
    }
}
