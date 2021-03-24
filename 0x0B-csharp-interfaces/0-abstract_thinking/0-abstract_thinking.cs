using System;

/// <summary>
/// Class base
/// </summary>
public abstract class Base
{
	public string name = null;
	/// <summary>
	/// Making the method .ToString() return the property name of the class
	/// and the type of class it is
	/// </summary>
	public override string ToString()
	{
		return $"{name} is a {this.GetType()};
	}
}
