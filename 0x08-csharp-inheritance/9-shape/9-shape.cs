using System;


/// <summary>This is a base class for shapes.</summary>
class Shape
{
    /// <summary>Calculates the area of a shape.</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// class rectangle
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    /// <summary>Property Width, must be positive.</summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (width < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                this.width = value;
        }
    }
    /// <summary>Property Height, must be positive.</summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (height < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                this.height = value;
        }
    }
    /// <summary>
    /// this method return the area of the rectangle
    /// instead of the message of the class shape
    /// </summary>
    public new int Area()
    {
        return (height * width);
    }
    /// <summary>
    /// This method overrides the .ToString method.
    /// </summary>
    public override string ToString()
    {
         return ($"[Rectangle] {width} / {height}");
    }
}
/// <summary>
/// class Square that inherits from Rectangle
/// </summary>
class Square : Rectangle
{
    private int size;
    public int Size
    {
        get { return size; }
        set
        {
            if (size < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
            {
                this.Height = value;
                this.Width = value;
                size = value;
            }
        }
    }
    /// <summary>Overides ToString method.</summary>
    public override string ToString()
    {
        return ($"[Square] {size} / {size}");
    }
}
