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
    /// Method Interact.
    /// </summary>
    void Interact();
}

/// <summary>
/// This interface determines if an object is breakable.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Property durability.
    /// </summary>
    int durability {get; set; }
    /// <summary>
    /// Method Break.
    /// </summary>
    void Break();
}

/// <summary>
/// This interface determines if an object is collectable.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Property isCollected.
    /// </summary>
    bool isCollected { get; set; }
    /// <summary>
    /// Method Collect.
    /// </summary>
    void Collect();
}

/// <summary>
/// A test class
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{

    /// <summary>
    /// durability property
    /// </summary>
    public int durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    /// <summary>
    /// Colecting property
    /// </summary>
    public bool isCollected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    /// <summary>
    /// This method allows interaction
    /// </summary>
    public void Interact()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// This method breaks
    /// </summary>
    public void Break()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// This method make you collect
    /// </summary>
    public void Collect()
    {
        throw new NotImplementedException();
    }
}

