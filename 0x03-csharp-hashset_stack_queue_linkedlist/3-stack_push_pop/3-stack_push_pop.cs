using System;
using System.Collections.Generic;


class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);

        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        
        else
            Console.WriteLine("Top item: {0}", aStack.Peek());

        bool contains = aStack.Contains(search);

        Console.WriteLine("Stack contains \"{0}\": {1}", search, contains);

        Stack<string> newStack = new Stack<string>(aStack);

        if (aStack.Contains(search))
        {
            foreach (var item in newStack)
            {
                if (aStack.Pop() == search)
                    break;
            }
        }

        aStack.Push(newItem);
        
        return(aStack);
    }
}
