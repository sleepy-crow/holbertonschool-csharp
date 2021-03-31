using System;

/// <summary>
/// this is the global namespace
/// </summary>
namespace InventoryLibrary
{
    /// <summary>
    /// Inventory class that inherits from the Base class
    /// </summary>
    public class Inventory : BaseClass
    {
        string user_id;
        string item_id;
        int quantity;

        public Inventory(string user_id = "john/jane_Id", string item_id = "Generic_Item_Id", int quantity = 1)
        {
            if (quantity < 0)
            {
                Console.WriteLine("the quantity cannot be less than 0");
                quantity = 1;
            }
                

            this.quantity = quantity;
            this.user_id = user_id;
            this.item_id = item_id;
        }
    }
}