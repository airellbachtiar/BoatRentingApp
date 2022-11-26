using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoatRentingClassLibrary;
using System.Collections.Generic;
using System;
using System.Linq;

namespace BoatRentingTest.ReservationClassTests
{
    [TestClass]
    public class ReservationControllerTests
    {

        ReservationController ReservationController = new ReservationController(new ReservationLocalStorage());
        InventoryItem inventoryItem;
        InventoryBoat inventoryBoat;
        User user;
        List<InventoryItem> inventoryItems = new List<InventoryItem>();
        Coupon coupon;

        //Set up reservation's items
        public ReservationControllerTests()
        {
            user = new User("a@a.a,", "name", "username", "a");

            Item item = new Item("test", 2, 2, "", false);
            Item item2 = new Item("test2", 3, 3, "", true);
            inventoryItem = new InventoryItem(item);
            inventoryBoat = new InventoryBoat(item2, 2);
            coupon = new Coupon("discount", 10);

            inventoryItems.Add(inventoryItem);
            inventoryItems.Add(inventoryBoat);

            //Make new reservation
            Reservation reservation = new Reservation(user, inventoryItems, DateTime.Now.AddDays(10), 4);
            ReservationController.AddReservation(reservation);
        }

        [TestMethod]
        public void A1_AddReservation_AssignUnavailableItem_ReturnFalse()
        {
            //Make unavailable item
            InventoryItem assignInventoryItem = inventoryItem;
            assignInventoryItem.IsAvailable = false;

            //assign to list
            inventoryItems.Add(assignInventoryItem);
            inventoryItems.Add(inventoryItem);

            //Make new reservation
            Reservation reservation = new Reservation(user, inventoryItems, DateTime.Now.AddDays(10), 4);

            Assert.IsFalse(ReservationController.AddReservation(reservation));
        }

        [TestMethod]
        public void A2_AddReservation_AssignPastDate_ReturnFalse()
        {
            //Make unavailable date
            DateTime startDate = DateTime.Now.AddDays(-2);

            //assign to list
            inventoryItems.Add(inventoryItem);
            inventoryItems.Add(inventoryItem);

            //Make new reservation
            Reservation reservation = new Reservation(user, inventoryItems, startDate, 4);

            Assert.IsFalse(ReservationController.AddReservation(reservation));
        }

        [TestMethod]
        public void A3_AddReservation_AssignWrongDuration_ReturnFalse()
        {
            //Make unavailable duration
            int duration = 3;

            //assign to list
            inventoryItems.Add(inventoryItem);
            inventoryItems.Add(inventoryItem);

            //Make new reservation
            Reservation reservation = new Reservation(user, inventoryItems, DateTime.Now.AddDays(10), duration);

            Assert.IsFalse(ReservationController.AddReservation(reservation));
        }

        [TestMethod]
        public void A4_AddReservation_ReturnTrue()
        {
            //assign to list
            inventoryItems.Add(inventoryItem);
            inventoryItems.Add(inventoryBoat);

            //Make new reservation
            Reservation reservation = new Reservation(user, inventoryItems, DateTime.Now.AddDays(10), 4);

            Assert.IsTrue(ReservationController.AddReservation(reservation));
        }

        [TestMethod]
        public void B1_UpdateReservation_AssignPastDate_ReturnFalse()
        {
            //Get reservation
            Reservation reservation = ReservationController.GetAllReservation().Last();

            //Update duration with wrong number
            reservation.DateDetail.StartDate = DateTime.Now.AddDays(-4);

            Assert.IsFalse(ReservationController.UpdateReservation(reservation));
        }

        [TestMethod]
        public void B2_UpdateReservation_AssignWrongDuration_ReturnFalse()
        {
            //Get reservation
            Reservation reservation = ReservationController.GetAllReservation().Last();

            //Update duration with wrong number
            reservation.DateDetail.Duration = 3;

            Assert.IsFalse(ReservationController.UpdateReservation(reservation));
        }

        [TestMethod]
        public void B3_UpdateReservation_ReturnTrue()
        {
            //Get reservation
            Reservation reservation = ReservationController.GetAllReservation().Last();

            //Update duration with correct format
            reservation.DateDetail.Duration = 4;
            reservation.DateDetail.StartDate = DateTime.Now.AddDays(10);

            Assert.IsTrue(ReservationController.UpdateReservation(reservation));
        }

        [TestMethod]
        public void C1_GetTotalPrice_ReturnTotalPrice()
        {
            //Get reservation
            Reservation reservation = ReservationController.GetAllReservation().Last();

            //expected total price
            double totalPrice = 5;

            Assert.AreEqual(totalPrice, reservation.PriceDetail.TotalPrice);
        }

        [TestMethod]
        public void C2_GetTotalDeposit_ReturnDepositPrice()
        {
            //Get reservation
            Reservation reservation = ReservationController.GetAllReservation().Last();

            //expected total deposit
            double totalDeposit = 5;

            Assert.AreEqual(totalDeposit, reservation.PriceDetail.TotalDeposit);
        }

        [TestMethod]
        public void C3_AssignCoupon_ReturnCoupon()
        {
            //Get reservation
            Reservation reservation = ReservationController.GetAllReservation().Last();

            //Assign coupon
            reservation.Coupon = coupon;

            Assert.AreEqual(coupon.Code, reservation.Coupon.Code);
        }

        [TestMethod]
        public void C4_GetTotalPrice_AfterAssigningCoupon_ReturnTotalPrice()
        {
            //Get reservation
            Reservation reservation = ReservationController.GetAllReservation().Last();

            //Assign Coupon
            reservation.Coupon = coupon;

            //Update duration with wrong number
            double totalPrice = 5 - (5 * 0.1);

            Assert.AreEqual(totalPrice, reservation.PriceDetail.TotalPrice);
        }

        [TestMethod]
        public void C5_AssignDamagePrice_ReturnDamagePrice()
        {
            //Get reservation
            Reservation reservation = ReservationController.GetAllReservation().Last();

            //assign damage price
            double damagePrice = 1;
            reservation.PriceDetail.DamagePrice = damagePrice;

            Assert.AreEqual(damagePrice, reservation.PriceDetail.DamagePrice);
        }

        [TestMethod]
        public void C6_GetActualPrice_ReturnActualPrice()
        {
            //Get reservation
            Reservation reservation = ReservationController.GetAllReservation().Last();

            //assign coupon
            reservation.Coupon = coupon;
            //assign damage price
            double damagePrice = 1;
            reservation.PriceDetail.DamagePrice = damagePrice;

            //expected actual price(total price - damage price)
            double actualPrice = (5 - (5 * 0.1)) - 1;

            Assert.AreEqual(actualPrice, reservation.PriceDetail.ActualPrice);
        }

        [TestMethod]
        public void C7_GetPriceCustomerPay_ReturnPrice()
        {
            //Get reservation
            Reservation reservation = ReservationController.GetAllReservation().Last();

            //assign coupon
            reservation.Coupon = coupon;
            //assign damage price
            double damagePrice = 1;
            reservation.PriceDetail.DamagePrice = damagePrice;

            //expected actual price(total deposit - total price)
            double customerPay = 5 - ((5 - (5 * 0.1)) - 1);

            Assert.AreEqual(customerPay, reservation.PriceDetail.CustomerPay);
        }

        [TestMethod]
        public void D1_RemoveReservation_ReturnTrue()
        {
            //Get reservation
            Reservation reservation = ReservationController.GetAllReservation().Last();

            Assert.IsTrue(ReservationController.RemoveReservation(reservation));
        }
    }
}
