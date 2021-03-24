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
    /// <summary>This is Interact.</summary>
    void Interact();
}

/// <summary>This is Interact.</summary>
public interface IBreakable
{
    /// <summary>This is Interact.</summary>
    int durability{ get; set; }
    /// <summary>This is Interact.</summary>
    void Break();
}

/// <summary>This is Interact.</summary>
public interface ICollectable
{
    /// <summary>This is Interact.</summary>
    bool isCollected{ get; set; }
    /// <summary>This is Interact.</summary>
    void Collect();
}

/// <summary>
/// This is Queue.
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>This is durability implemented int.</summary>
    public int durability{ get => throw new NotImplementedException() ; set => throw new NotImplementedException(); }
    /// <summary>This is isCollected implemented bool.</summary>
    public bool isCollected{ get => throw new NotImplementedException() ; set => throw new NotImplementedException(); }
    /// <summary>This is Interact.</summary>
    public void Interact()
    {
        throw new NotImplementedException();
    }

    /// <summary>This is break.</summary>
    public void Break()
    {
        throw new NotImplementedException();
    }

    /// <summary>This is Collect.</summary>
    public void Collect()
    {
        throw new NotImplementedException();
    }
}
