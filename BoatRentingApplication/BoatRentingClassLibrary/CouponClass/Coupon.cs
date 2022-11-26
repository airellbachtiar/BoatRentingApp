using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class Coupon
    {
        public Coupon(string code, int discount)
        {
            Code = code;
            Discount = discount;
        }

        public int CouponID { get; set; }
        public string Code { get; set; }
        public int Discount { get; set; }
    }
}
