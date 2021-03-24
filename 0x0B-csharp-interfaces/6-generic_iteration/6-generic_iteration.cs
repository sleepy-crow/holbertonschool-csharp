using System;
using System.Collections.Generic;
using System.Collections;

/// <summary>
/// abstract class called Base
/// </summary>
public abstract class Base
{
    /// <summary>
    /// property
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// abstract class called Base
    /// </summary>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType().Name}";
    }
}

/// <summary>
/// an interface called IInteractive
/// </summary>
public interface  IInteractive
{
    /// <summary>
    /// method Interact
    /// </summary>
    void Interact();
}

/// <summary>
/// an interface called IBreakable
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// property durability
    /// </summary>
    int durability { get; set; }
    /// <summary>
    /// method Break
    /// </summary>
    void Break();
}

/// <summary>
/// an interface called IBreakable
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// property isCollected
    /// </summary>
    bool isCollected { get; set; }
    /// <summary>
    /// method Collect
    /// </summary>
    void Collect();
}

/// <summary>
/// class called Door
/// </summary>
class Door : Base, IInteractive
{
    /// <summary>
    /// constructor that sets the value of name.
    /// </summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interaction with a door.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}

/// <summary>
/// class Decoration
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Property isQuestItem
    /// </summary>
    public bool isQuestItem;
    /// <summary>
    /// Property durability
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Constructor.
    /// </summary>
    public Decoration (string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Method Interact
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {this.name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else if (isQuestItem == false)
        {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Method Break
    /// </summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }
        if (durability == 0)
        {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        }
        if (durability < 0)
        {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }
}

/// <summary>
/// class Key
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Property isCollected
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Constructor.
    /// </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Method Collect
    /// </summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {this.name}.");
        }
        else if (isCollected == true)
        {
            Console.WriteLine($"You have already picked up the {this.name}.");
        }
    }

}

/// <summary>
/// Class obj
/// </summary>
public class Objs<T> : IEnumerable<T>
{
    List<T> temp = new List<T>();

    /// <summary>
    /// Method that adds.
    /// </summary>
    public void Add(T item)
    {
        temp.Add(item);
    }

    /// <summary>
    /// Returns the list to be enumerated.
    /// </summary>
    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in temp)
        {
            yield return item;
        }
    }

    /// <summary>
    /// Generic version.
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}