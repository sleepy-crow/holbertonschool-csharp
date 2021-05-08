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
        public string name { get; set; }

        public User(string name = "John Doe / Jane Doe")
        {
            this.name = name;
        }

        public override string ToString()
        {
            string returnValue = $"Object: {this.GetType().Name}\nName: {this.name}\nId: {this.id}\nCreation Date: {this.date_created}\nUpdated Date: {this.date_updated}";
            return (returnValue);
        }
    }
}