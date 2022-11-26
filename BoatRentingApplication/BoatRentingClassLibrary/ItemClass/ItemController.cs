using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class ItemController
    {
        private List<Item> items;
        private IStorageOption<Item> itemDAL;

        public ItemController(IStorageOption<Item> itemDAL)
        {
            this.itemDAL = itemDAL;
        }

        public List<Item> GetAllItem()
        {
            items = itemDAL.GetAll();
            return items;
        }

        public Item GetItem(int id)
        {
            //refresh items
            items = GetAllItem();

            foreach (Item i in items)
            {
                //search through matching id
                if (i.ItemID == id)
                {
                    return i;
                }
            }
            return null;
        }

        public bool AddItem(Item item)
        {
            items = GetAllItem();

            //assign item id
            if (items.Count != 0)
            {
                //get highest id and adds 1
                int highestID = items.Max(item => item.ItemID);
                item.ItemID = ++highestID;
            }
            else
            {
                //assign id 1 if it's the first entry
                item.ItemID = 1;
            }

            //check duplicate name
            bool result = CheckDuplicate(item);

            if (result)
            {
                return itemDAL.Add(item);
            }
            return result;
        }

        public bool UpdateItem(Item item)
        {
            return itemDAL.Update(item);
        }

        public bool RemoveItem(Item item)
        {
            return itemDAL.Remove(item);
        }

        private bool CheckDuplicate(Item item)
        {
            foreach (Item it in items)
            {
                //check duplicate name
                if (it.Name == item.Name)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
