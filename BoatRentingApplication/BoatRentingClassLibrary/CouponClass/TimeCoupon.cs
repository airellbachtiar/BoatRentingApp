using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class TimeCoupon : Coupon
    {
        public TimeCoupon(Coupon coupon, DateTime endDate) : base(coupon.Code, coupon.Discount)
        {
            EndDate = endDate;
        }
        public DateTime EndDate { get; set; }
    }
}
