﻿using System;

///<summary>This is the Queue Class.</summary>
public class Queue<T>
{

    ///<summary>Head of the Queue.</summary>
    public Node head = null;
    ///<summary>Tail of the Queue.</summary>
    public Node tail = null;
    ///<summary>Counter of the nodes in Queue.</summary>
    public int count;

    ///<summary>This is a class to add nodes to the Queue.</summary>
    public class Node
    {
        ///<summary>This is the value to store in the node.</summary>
        public T value = default(T);
        ///<summary>This is the next node.</summary>
        public Node Next = null;

        ///<summary>This method gives a value to the value variable.</summary>
        public Node(T var)
        {
            value = var;
        }
    }
    
    ///<summary>This method returns the Queue's type.</summary>
    public Type CheckType() => typeof(T);

    ///<summary>This method adds an element to the end of the Queue.</summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }

        count += 1;
    }

    ///<summary>This method returns the number of elements in the Queue.</summary>
    public int Count() => count;
}
