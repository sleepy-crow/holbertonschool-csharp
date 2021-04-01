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

        public void All()
        {
            return (this.objects);
        }
        public void New(BaseClass obj)
        {
            objects.Add(obj.GetType().Name + "." + obj.id, obj);
        }
        public void Save()
        {
            
        }
        public void Load()
        {
            
        }
    }
}