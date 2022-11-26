using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public static class ReservationCalculator
    {
        //count price from list of inventory items
        public static double CalculatePrice(List<InventoryItem> inventoryItems)
        {
            double price = 0;
            foreach (InventoryItem i in inventoryItems)
            {
                price = price + i.Item.Cost;
            }
            return price;
        }

        //count deposit from list of inventory items
        public static double CalculateDeposit(List<InventoryItem> inventoryItems)
        {
            double deposit = 0;
            foreach (InventoryItem i in inventoryItems)
            {
                deposit = deposit + i.Item.Deposit;
            }
            return deposit;
        }
    }
}
