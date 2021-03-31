using System;

/// <summary>
/// this is the global namespace
/// </summary>
namespace InventoryLibrary
{
    /// <summary>
    /// User class that inherits from the Base class
    /// </summary>
    public class User : BaseClass
    {
        public string name { get; }

        public Item(string name = "John / Jane Doe")
        {
            this.name = name;
        }
    }
}