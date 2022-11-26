using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class LimitedCoupon : Coupon
    {
        public LimitedCoupon(Coupon coupon, int totalUses) : base(coupon.Code, coupon.Discount)
        {
            TotalUses = totalUses;
            RemainingUses = totalUses;
        }
        public int TotalUses { get; set; }
        public int RemainingUses { get; set; }
    }
}
