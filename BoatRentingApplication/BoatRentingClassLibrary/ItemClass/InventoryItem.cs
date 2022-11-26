using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class InventoryItem
    {
        public InventoryItem(Item item)
        {
            this.item = item;
            Status = "Available";
            IsAvailable = true;
        }

        private Item item;

        public int InventoryID { get; set; }
        public string Status { get; set; }
        public bool IsAvailable { get; set; }
        public Item Item { get { return item; } set { item = value; } }
    }
}
