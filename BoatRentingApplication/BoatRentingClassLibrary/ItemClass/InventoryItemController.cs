using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class InventoryItemController
    {
        private List<InventoryItem> inventoryItems;
        private IStorageOption<InventoryItem> inventoryItemDAL;

        public InventoryItemController(IStorageOption<InventoryItem> inventoryItemDAL)
        {
            this.inventoryItemDAL = inventoryItemDAL;
        }

        public List<InventoryItem> GetAllInventoryItem()
        {
            inventoryItems = inventoryItemDAL.GetAll();
            return inventoryItems;
        }

        //Get specific inventory item
        public InventoryItem GetInventoryItem(int inventoryId)
        {
            //Refresh inventory items
            inventoryItems = GetAllInventoryItem();

            foreach (InventoryItem i in inventoryItems)
            {
                //check matching id
                if (i.InventoryID == inventoryId)
                {
                    return i;
                }
            }

            //if id didn't found
            return null;
        }

        //get inventory items from the same item with specific amount of number
        public List<InventoryItem> GetInventoryItems(int itemId, int amount)
        {
            //refresh inventory items
            inventoryItems = GetAllInventoryItem();
            List<InventoryItem> tempInventoryItems = new List<InventoryItem>();

            //search for "amount" of times
            for (int i = 0; i < amount; i++)
            {
                foreach (InventoryItem inv in inventoryItems)
                {
                    List<InventoryItem> addedItem = new List<InventoryItem>();

                    //search for available item with matching id
                    if (inv.Item.ItemID == itemId && !tempInventoryItems.Contains(inv) && inv.IsAvailable)
                    {
                        //add inventory item to list
                        tempInventoryItems.Add(inv);
                        break;
                    }
                }
            }

            //Check if it got the correct amount of inventory items
            if (tempInventoryItems.Count != amount)
            {
                return null;
            }
            else
                return tempInventoryItems;
        }

        public bool AddInventoryItem(InventoryItem inventoryItem)
        {
            //Refresh inventory items
            inventoryItems = GetAllInventoryItem();

            //Assign id for new inventory items
            if (inventoryItems.Count != 0)
            {
                //get highest id and add 1 to it and assign it
                int highestID = inventoryItems.Max(inventoryItem => inventoryItem.InventoryID);
                inventoryItem.InventoryID = ++highestID;
            }
            else
            {
                //assign 1 if it's the first entry
                inventoryItem.InventoryID = 1;
            }

            return inventoryItemDAL.Add(inventoryItem);
        }

        public bool UpdateInventoryItem(InventoryItem inventoryItem)
        {
            return inventoryItemDAL.Update(inventoryItem);
        }

        public bool RemoveInventoryItem(InventoryItem inventoryItem)
        {
            return inventoryItemDAL.Remove(inventoryItem);
        }
    }
}
