using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class InventoryItemLocalStorage : IStorageOption<InventoryItem>
    {
        public List<InventoryItem> GetAll()
        {
            return TemporaryStorage.InventoryItemList.Cast<InventoryItem>().ToList();
        }

        public bool Add(InventoryItem obj)
        {
            List<InventoryItem> inventoryItems = GetAll();
            inventoryItems.Add(obj);
            TemporaryStorage.InventoryItemList = inventoryItems;
            return true;
        }

        public bool Update(InventoryItem obj)
        {
            List<InventoryItem> inventoryItems = GetAll();

            //search inventory items and replace it
            for (int i = 0; i < inventoryItems.Count; i++)
            {
                if (inventoryItems[i].InventoryID == obj.InventoryID)
                {
                    inventoryItems[i] = obj;
                    break;
                }
            }
            //Replace list
            TemporaryStorage.InventoryItemList = inventoryItems;
            return true;
        }

        public bool Remove(InventoryItem obj)
        {
            List<InventoryItem> inventoryItems = GetAll();
            inventoryItems.Remove(obj);
            TemporaryStorage.InventoryItemList = inventoryItems;
            return true;
        }
    }
}
