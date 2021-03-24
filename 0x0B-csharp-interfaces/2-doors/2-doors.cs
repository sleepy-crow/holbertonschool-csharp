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