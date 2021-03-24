using System;

/// <summary>
/// Class base
/// </summary>
public abstract class Base
{
	/// <summary>
	///  the name the class will recive
	/// </summary>
	public string name { get; set; }
	/// <summary>
	/// Making the method .ToString() return the property name of the class
	/// and the type of class it is
	/// </summary>
	public override string ToString()
	{
		return name + " is a " + this.GetType();
	}
}

/// <summary>
/// This interface determines if an object is interactable.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// This is Interact.
    /// </summary>
    void Interact();
}

/// <summary>
/// This is Interact.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// This is Interact.
    /// </summary>
    int durability{ get; set; }
    /// <summary>
    /// This is Interact.
    /// </summary>
    void Break();
}

/// <summary>
/// This is Interact.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// This is Interact.
    /// </summary>
    bool isCollected{ get; set; }
    /// <summary>
    /// This one collect.
    /// </summary>
    void Collect();
}

/// <summary>
/// This is the door namer.
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>This is Interact.</summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }
    /// <summary>
    /// This is Interact.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
/// <summary>
/// This is Interact.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// This is the durability
    /// </summary>
    public int durability{ get; set; }
    /// <summary>
    /// This is a quest item
    /// </summary>
    public bool isQuestItem;

    /// <summary>
    /// This is the decoration
    /// </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
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
    /// This is Interact.
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else
        {
            if (isQuestItem)
            {
                Console.WriteLine($"You look at the {name}. There's a key inside.");
            }
            else
            {
                Console.WriteLine($"You look at the {name}. Not much to see here.");
            }
        }
    }

    /// <summary>
    /// This is Interact.
    /// </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if(durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else if(durability < 0)
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>
/// These are keys
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// This is a collector
    /// </summary>
    public bool isCollected{get; set;}
    /// <summary>
    /// This is Interact.
    /// </summary>
    public Key(string name = "key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Here is the collection
    /// </summary>
    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else if (isCollected)
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}