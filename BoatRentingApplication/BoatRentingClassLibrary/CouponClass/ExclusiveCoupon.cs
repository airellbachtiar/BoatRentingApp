using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class ExclusiveCoupon : Coupon
    {
        public ExclusiveCoupon(Coupon coupon, int customerID) : base(coupon.Code, coupon.Discount)
        {
            CustomerID = customerID;
            IsRedeeemed = false;
        }
        public int CustomerID { get; set; }
        public bool IsRedeeemed { get; set; }
    }
}
