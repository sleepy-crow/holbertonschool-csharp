using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;


/// <summary>
/// this is the global namespace
/// </summary>
namespace InventoryLibrary
{
    public class JSONStorage
    {
        public Dictionary<string, object> objects = new Dictionary<string, object>();

        string filePath = @"./storage/inventory_manager.json";

        public Dictionary<string, object> All()
        {
            return (this.objects);
        }

        public void New(string nameClass)
        {
            if (nameClass == "item")
            {
                Item newItem = new Item();
                objects.Add(nameClass + "." + newItem.id, newItem);
            }
            else if (nameClass == "user")
            {
                User newUser = new User();
                objects.Add(nameClass + "." + newUser.id, newUser);
            }
            else
            {
                Inventory newInv = new Inventory();
                objects.Add(nameClass + "." + newInv.id, newInv);
            }
        }


        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
            };

            string jsonString = JsonSerializer.Serialize<Dictionary<string, object>>(objects, options);

            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine(jsonString);
            }
        }
        
        public void Load()
        {
            string jsonString = "{}";
            try
            {
                using (StreamReader sw = File.OpenText(filePath))
                {
                    jsonString = File.ReadAllText(filePath);
                }
                objects = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString);
            }
            catch (JsonException)
            {
                Console.WriteLine("JSON File does not contain info");
            }
        }
    }
}