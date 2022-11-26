using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class CouponLocalStorage : IStorageOption<Coupon>
    {
        public List<Coupon> GetAll()
        {
            return TemporaryStorage.CouponList.Cast<Coupon>().ToList();
        }

        public bool Add(Coupon obj)
        {
            List<Coupon> coupons = GetAll();
            coupons.Add(obj);
            TemporaryStorage.CouponList = coupons;
            return true;
        }

        public bool Update(Coupon obj)
        {
            List<Coupon> coupons = GetAll();
            //replace coupon
            for (int i = 0; i < coupons.Count; i++)
            {
                if (coupons[i].CouponID == obj.CouponID)
                {
                    coupons[i] = obj;
                    break;
                }
            }

            //Replace coupon list
            TemporaryStorage.CouponList = coupons;
            return true;
        }

        public bool Remove(Coupon obj)
        {
            List<Coupon> coupons = GetAll();
            coupons.Remove(obj);
            TemporaryStorage.CouponList = coupons;
            return true;
        }
    }
}
