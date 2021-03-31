using System;
using System.Text.json;
using System.Collections.Generic;

/// <summary>
/// this is the global namespace
/// </summary>
namespace InventoryLibrary
{
    public class JSONStorage
    {
        public Dictionary<string, object> objects = new IDictionary<string, object>();

        public Dictionary<string, object> All()
        {
            return (this.objects);
        }
    }
}