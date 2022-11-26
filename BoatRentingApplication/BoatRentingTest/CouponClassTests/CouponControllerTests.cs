using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoatRentingClassLibrary;
using System;
using System.Collections.Generic;

namespace BoatRentingTest.CouponClassTests
{
    [TestClass]
    public class CouponControllerTests
    {
        CouponController couponController = new CouponController(new CouponLocalStorage());
        ExclusiveCoupon exclusiveCoupon = new ExclusiveCoupon(new Coupon("TestExclusiveCoupon", 5), 1);
        LimitedCoupon limitedCoupon = new LimitedCoupon(new Coupon("TestLimitedCoupon", 5), 5);
        TimeCoupon timeCoupon = new TimeCoupon(new Coupon("TestTimeCoupon", 5), DateTime.Parse("25-12-2021"));

        public CouponControllerTests()
        {
            TemporaryStorage.CouponList = new List<Coupon>();
        }

        [TestMethod]
        public void A1_AddExclusiveCoupon_ReturnAddedExclusiveCoupon()
        {
            couponController.AddCoupon(exclusiveCoupon);
            Coupon coupon = GetCoupon(exclusiveCoupon.Code);
            Assert.AreEqual(exclusiveCoupon.Code, coupon.Code);
        }

        [TestMethod]
        public void A2_UpdateExclusiveCoupon_ReturnNewCustomerID()
        {
            couponController.AddCoupon(exclusiveCoupon);
            ExclusiveCoupon coupon = (ExclusiveCoupon)GetCoupon(exclusiveCoupon.Code);
            coupon.CustomerID = 2;
            couponController.UpdateCoupon(coupon);

            ExclusiveCoupon updatedCoupon = (ExclusiveCoupon)GetCoupon(exclusiveCoupon.Code);
            Assert.AreEqual(2, updatedCoupon.CustomerID);
        }

        [TestMethod]
        public void A4_RemoveExclusiveCoupon_ReturnTrue()
        {
            couponController.AddCoupon(exclusiveCoupon);
            Coupon coupon = GetCoupon(exclusiveCoupon.Code);
            Assert.IsTrue(couponController.RemoveCoupon(coupon));
        }

        [TestMethod]
        public void B1_AddLimitedCoupon_ReturnAddedLimitedCoupon()
        {
            couponController.AddCoupon(limitedCoupon);
            Coupon coupon = GetCoupon(limitedCoupon.Code);
            Assert.AreEqual(limitedCoupon.Code, coupon.Code);
        }

        [TestMethod]
        public void B2_UpdateLimitedCoupon_ReturnRemainingUses()
        {
            couponController.AddCoupon(limitedCoupon);
            LimitedCoupon coupon = (LimitedCoupon)GetCoupon(limitedCoupon.Code);
            coupon.RemainingUses -= 1;
            couponController.UpdateCoupon(coupon);

            LimitedCoupon updatedCoupon = (LimitedCoupon)GetCoupon(limitedCoupon.Code);
            Assert.AreEqual(4, updatedCoupon.RemainingUses);
        }

        [TestMethod]
        public void B3_RemoveLimitedCoupon_ReturnTrue()
        {
            couponController.AddCoupon(limitedCoupon);
            Coupon coupon = GetCoupon(limitedCoupon.Code);
            Assert.IsTrue(couponController.RemoveCoupon(coupon));
        }

        [TestMethod]
        public void C1_AddTimeCoupon_ReturnAddedTimeCoupon()
        {
            couponController.AddCoupon(timeCoupon);
            Coupon coupon = GetCoupon(timeCoupon.Code);
            Assert.AreEqual(timeCoupon.Code, coupon.Code);
        }

        [TestMethod]
        public void C2_UpdateTimeCoupon_ReturnNewDate()
        {
            couponController.AddCoupon(timeCoupon);

            TimeCoupon coupon = (TimeCoupon)GetCoupon(timeCoupon.Code);
            DateTime date = DateTime.Parse("27-12-2021");
            coupon.EndDate = date;
            couponController.UpdateCoupon(coupon);

            TimeCoupon updatedCoupon = (TimeCoupon)GetCoupon(timeCoupon.Code);
            Assert.AreEqual(date, updatedCoupon.EndDate);
        }

        [TestMethod]
        public void C3_RemoveTimeCoupon_ReturnTrue()
        {
            couponController.AddCoupon(timeCoupon);

            Coupon coupon = GetCoupon(timeCoupon.Code);
            Assert.IsTrue(couponController.RemoveCoupon(coupon));
        }

        private Coupon GetCoupon(string code)
        {
            foreach (Coupon c in couponController.GetAllCoupon())
            {
                if (c.Code == code)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
