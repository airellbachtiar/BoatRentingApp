using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class ReservationPriceDetail
    {
        private List<InventoryItem> inventoryItems;
        public ReservationPriceDetail(List<InventoryItem> inventoryItems)
        {
            this.inventoryItems = inventoryItems;
        }

        //count total deposit
        public double TotalDeposit { get { 
                double totalDeposit = ReservationCalculator.CalculateDeposit(inventoryItems);
                return totalDeposit;
            } }

        //count total price with discount
        public double TotalPrice { get {
                double totalPrice = ReservationCalculator.CalculatePrice(inventoryItems);
                if (Discount != 0)
                {
                    double discount = totalPrice * (Discount / 100);
                    totalPrice = totalPrice - discount;
                }
                return totalPrice;
            } }
        public double Discount { get; set; }

        //total price - damage price
        public double ActualPrice { get {
                return TotalPrice - DamagePrice;}
        }
        public double DamagePrice { get; set; }

        public double CustomerPay { get {
                return TotalDeposit - ActualPrice;
            } }
    }
}
