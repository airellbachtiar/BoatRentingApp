using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class CouponController
    {
        private List<Coupon> coupons;
        private IStorageOption<Coupon> couponDAL;

        public CouponController(IStorageOption<Coupon> couponDAL)
        {
            this.couponDAL = couponDAL;
        }

        public List<Coupon> GetAllCoupon()
        {
            coupons = couponDAL.GetAll();
            return coupons;
        }

        public Coupon GetCoupon(int couponID)
        {
            //Refresh all available coupon
            coupons = GetAllCoupon();

            //Search through coupon
            foreach (Coupon c in GetAllCoupon())
            {
                //Check coupon id and return coupon
                if (c.CouponID == couponID)
                {
                    return c;
                }
            }
            //if coupon not found, return null
            return null;
        }

        public bool AddCoupon(Coupon coupon)
        {
            //Refresh coupon
            coupons = GetAllCoupon();

            //Assign coupon id
            if (coupons.Count != 0)
            {
                //get the highest id and assign it bigger than that
                int highestID = coupons.Max(coupon => coupon.CouponID);
                coupon.CouponID = ++highestID;
            }
            else
            {
                //if it's new submission, assign it to 1
                coupon.CouponID = 1;
            }

            //Check duplicate
            bool result = CheckDuplicate(coupon);

            //if it's not duplicate
            if (result)
            {
                return couponDAL.Add(coupon);
            }
            return result;
        }

        public bool UpdateCoupon(Coupon coupon)
        {
            return couponDAL.Update(coupon);
        }

        public bool RemoveCoupon(Coupon coupon)
        {
            return couponDAL.Remove(coupon);
        }

        public Coupon AssignCoupon(User user, Coupon previousCoupon, Coupon newCoupon)
        {
            //Assign new Coupon
            if (newCoupon != null)
            {
                if (CheckAssignCoupon(newCoupon, user))
                {
                    //if true, new coupon is returned
                    return newCoupon;
                }
            }
            //Cancel a coupon
            else
            {
                if (CheckCancelCoupon(previousCoupon))
                {
                    //if true, return no coupon
                    return null;
                }
            }
            //If all fails, previous coupon is returned
            return previousCoupon;
        }

        private bool CheckAssignCoupon(Coupon coupon, User user)
        {
            //check coupon type
            if (coupon is ExclusiveCoupon)
            {
                //check if it viable to assign
                if (((ExclusiveCoupon)coupon).CustomerID == user.ID)
                {
                    //Update coupon and returns it
                    ((ExclusiveCoupon)coupon).IsRedeeemed = false;
                    UpdateCoupon(coupon);
                    return true;
                }
            }
            else if (coupon is LimitedCoupon)
            {
                //check if it viable to assign
                if (((LimitedCoupon)coupon).RemainingUses != 0)
                {
                    //Update coupon and returns it
                    ((LimitedCoupon)coupon).RemainingUses -= 1;
                    UpdateCoupon(coupon);
                    return true;
                }
            }
            else if (coupon is TimeCoupon)
            {
                //check if it viable to assign
                if (((TimeCoupon)coupon).EndDate > DateTime.Now)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckCancelCoupon(Coupon coupon)
        {
            try
            {
                //Check coupon type
                if (coupon is ExclusiveCoupon)
                {
                    //Update coupon
                    ((ExclusiveCoupon)coupon).IsRedeeemed = true;
                    UpdateCoupon(coupon);
                }
                else if (coupon is LimitedCoupon)
                {
                    //Update coupon
                    ((LimitedCoupon)coupon).RemainingUses += 1;
                    UpdateCoupon(coupon);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool CheckDuplicate(Coupon coupon)
        {
            coupons = GetAllCoupon();
            foreach (Coupon c in coupons)
            {
                //check if its have the same code
                if (c.Code == coupon.Code)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
