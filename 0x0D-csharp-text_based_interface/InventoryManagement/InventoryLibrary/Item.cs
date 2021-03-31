using System;
using System.Collections.Generic;

/// <summary>
/// this is the global namespace
/// </summary>
namespace InventoryLibrary
{
    /// <summary>
    /// Item class that inherits from the Base class
    /// </summary>
    public class Item : BaseClass
    {
        public string name { get; }
        public string description;
        public float price;
        public List<string> tags = new List<string>();      

        public Item(string name = "Generic_Item") 
        {
            this.name = name;
        }
    }
}