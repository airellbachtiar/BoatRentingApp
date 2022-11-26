using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class ItemLocalStorage : IStorageOption<Item>
    {
        public List<Item> GetAll()
        {
            return TemporaryStorage.ItemList.Cast<Item>().ToList();
        }

        public bool Add(Item obj)
        {
            List<Item> items = GetAll();
            items.Add(obj);
            TemporaryStorage.ItemList = items;
            return true;
        }
        
        public bool Update(Item obj)
        {
            List<Item> items = GetAll();

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemID == obj.ItemID)
                {
                    items[i] = obj;
                    break;
                }
            }

            TemporaryStorage.ItemList = items;
            return true;
        }

        public bool Remove(Item obj)
        {
            List<Item> items = GetAll();
            items.Remove(obj);
            TemporaryStorage.ItemList = items;
            return true;
        }
    }
}
