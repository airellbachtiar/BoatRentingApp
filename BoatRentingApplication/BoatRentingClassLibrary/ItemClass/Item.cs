using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class Item
    {
        public Item(string name, double cost, double deposit, string description, bool isBoat)
        {
            Name = name;
            Cost = cost;
            Deposit = deposit;
            Description = description;
            IsBoat = isBoat;
        }

        public int ItemID { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Deposit { get; set; }
        public string Description { get; set; }
        public bool IsBoat { get; set; }
    }
}
