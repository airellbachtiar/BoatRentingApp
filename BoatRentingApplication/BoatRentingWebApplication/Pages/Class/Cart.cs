using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoatRentingClassLibrary;

namespace BoatRentingWebApplication.Pages
{
    public class Cart
    {
        public Cart(Item item, int amount)
        {
            Item = item;
            Amount = amount;
        }
        public Item Item { get; }
        public int Amount { get; set; }
    }
}
