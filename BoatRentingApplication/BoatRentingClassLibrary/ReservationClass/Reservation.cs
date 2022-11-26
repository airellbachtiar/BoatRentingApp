using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class Reservation
    {
        public Reservation(User user, List<InventoryItem> inventoryItems, DateTime startDate, int duration)
        {
            this.user = user;
            this.inventoryItems = inventoryItems;
            dateDetail = new ReservationDateDetail(startDate, duration);
            priceDetail = new ReservationPriceDetail(inventoryItems);

            //assign status
            if (startDate.AddHours(duration) > DateTime.Now)
                Status = ReservationStatus.COMING_SOON.ToString();
        }

        private ReservationDateDetail dateDetail;
        private ReservationPriceDetail priceDetail;

        private User user;
        private Coupon coupon;
        private List<InventoryItem> inventoryItems;

        private Address address;

        public int ReferenceNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }

        public ReservationDateDetail DateDetail { get { return dateDetail; } set { dateDetail = value; } }
        public ReservationPriceDetail PriceDetail { get { return priceDetail; } set { priceDetail = value; } }

        public User User { get { return user; } set { user = value; } }
        public Coupon Coupon { get { return coupon; } 
            set { 
                //check coupon null or not
                if (value != null)
                {
                    //assign discount
                    priceDetail.Discount = value.Discount;
                }
                else
                {
                    priceDetail.Discount = 0;
                }
                coupon = value;
            } }
        public List<InventoryItem> InventoryItems { get { return inventoryItems; } set { inventoryItems = value; } }

        public Address Address { get { return address; } set { address = value; } }
    }
}
