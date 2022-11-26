using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class ReservationDAL : IStorageOption<Reservation>
    {
        IStorageAccess _ReservationDBAcess;

        //create controller for changes
        private InventoryItemController inventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));

        public ReservationDAL(IStorageAccess dbAccessReservation)
        {
            _ReservationDBAcess = dbAccessReservation;
        }

        public List<Reservation> GetAll()
        {
            try
            {
                List<Reservation> reservations = new List<Reservation>();

                //Get reservation table with address registered from sql
                string sql = "SELECT * FROM `reservation` INNER JOIN `renteeaddress` ON reservation.ReferenceNumber = renteeaddress.ReferenceNumber";
                DataTable reservationTable = _ReservationDBAcess.GetData(sql);

                //Setup controller for calling objects
                UserController userController = new UserController(new CustomerController(new CustomerDAL(new DBAccess(DatabaseHelper.mainDatabase))));
                CouponController couponController = new CouponController(new CouponDAL(new DBAccess(DatabaseHelper.mainDatabase)));

                if (reservationTable.Rows.Count != 0)
                {
                    foreach (DataRow row in reservationTable.Rows)
                    {
                        //Extract data from table
                        int referenceNumber = Convert.ToInt32(row["ReferenceNumber"].ToString());
                        int customerID = Convert.ToInt32(row["CustomerID".ToString()]);
                        string location = row["Location"].ToString();
                        DateTime DateCreated = DateTime.Parse(row["DateCreated"].ToString());
                        DateTime startDate = DateTime.Parse(row["StartDate"].ToString());
                        int duration = Convert.ToInt32(row["Duration"].ToString());
                        int couponID = Convert.ToInt32(row["CouponID"].ToString());
                        double damagePrice = Convert.ToDouble(row["DamagePrice"].ToString());
                        double finalPrice = Convert.ToDouble(row["FinalPrice"].ToString());
                        string status = row["Status"].ToString();

                        //Data for address
                        string streetName = row["Street"].ToString();
                        string zipCode = row["ZipCode"].ToString();
                        int houseNumber = Convert.ToInt32(row["HouseNumber"].ToString());
                        string city = row["City"].ToString();
                        string phoneNumber = row["PhoneNumber"].ToString();
                        Address address = new Address(streetName, zipCode, houseNumber, city);

                        //Get inventoryItem table that are rented
                        sql = $"SELECT * FROM `renteditem` WHERE ReferenceNumber = {referenceNumber}";
                        DataTable rentedItemTable = _ReservationDBAcess.GetData(sql);
                        List<InventoryItem> rentedItems = new List<InventoryItem>();

                        if (rentedItemTable.Rows.Count != 0)
                        {
                            List<InventoryItem> inventoryItems = inventoryItemController.GetAllInventoryItem();
                            foreach (DataRow rentedRow in rentedItemTable.Rows)
                            {
                                int inventoryItemID = Convert.ToInt32(rentedRow["InventoryItemID"].ToString());
                                rentedItems.Add(inventoryItems.Where(inv => inv.InventoryID == inventoryItemID).FirstOrDefault());
                            }
                        }

                        //Assigning data to object reservation
                        User user = userController.GetUser(customerID);
                        Reservation reservation = new Reservation(user, rentedItems, startDate, duration);
                        reservation.ReferenceNumber = referenceNumber;
                        reservation.Location = location;
                        reservation.DateDetail.DateCreated = DateCreated;
                        if (couponID != 0)
                        {
                            reservation.Coupon = couponController.GetCoupon(couponID);
                        }
                        reservation.PriceDetail.DamagePrice = damagePrice;
                        reservation.PhoneNumber = phoneNumber;
                        reservation.Status = status;

                        reservation.Address = address;

                        reservations.Add(reservation);
                    }
                }

                return reservations;
            }
            catch (Exception)
            {
                return new List<Reservation>();
            }
        }

        public bool Update(Reservation reservation)
        {
            try
            {
                //Update reservation
                string sql = $"UPDATE `reservation` SET `CustomerID`='{reservation.User.ID}',`Location`='{reservation.Location}',`DateCreated`='{DatabaseHelper.DateConverterToDB(reservation.DateDetail.DateCreated)}',`StartDate`='{DatabaseHelper.DateConverterToDB(reservation.DateDetail.StartDate)}',`Duration`='{reservation.DateDetail.Duration}',`DamagePrice`='{reservation.PriceDetail.DamagePrice.ToString().Replace(',', '.')}',`FinalPrice`='{reservation.PriceDetail.ActualPrice.ToString().Replace(',', '.')}',`Status`='{reservation.Status}' WHERE `ReferenceNumber`='{reservation.ReferenceNumber}'";
                _ReservationDBAcess.PostData(sql);

                //Set coupon id
                if (reservation.Coupon != null)
                {
                    sql = $"UPDATE `reservation` SET `CouponID`='{reservation.Coupon.CouponID}' WHERE `ReferenceNumber`='{reservation.ReferenceNumber}'";
                    _ReservationDBAcess.PostData(sql);
                }
                else
                {
                    sql = $"UPDATE `reservation` SET `CouponID`='0' WHERE `ReferenceNumber`='{reservation.ReferenceNumber}'";
                    _ReservationDBAcess.PostData(sql);
                }

                //Update address
                sql = $"UPDATE `renteeaddress` SET `Street`='{reservation.Address.StreetName}',`Zipcode`='{reservation.Address.ZipCode}',`HouseNumber`='{reservation.Address.HouseNumber}',`City`='{reservation.Address.City}',`PhoneNumber`='{reservation.PhoneNumber}' WHERE `ReferenceNumber`='{reservation.ReferenceNumber}'";
                _ReservationDBAcess.PostData(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add(Reservation reservation)
        {
            try
            {
                //Add reservation
                string sql = $"INSERT INTO `reservation`(`ReferenceNumber`, `CustomerID`, `Location`, `DateCreated`, `StartDate`, `Duration`, `CouponID`, `DamagePrice`, `FinalPrice`, `Status`) VALUES ('{reservation.ReferenceNumber}','{reservation.User.ID}','{reservation.Location}','{DatabaseHelper.DateConverterToDB(reservation.DateDetail.DateCreated)}','{DatabaseHelper.DateConverterToDB(reservation.DateDetail.StartDate)}','{reservation.DateDetail.Duration}','0','{reservation.PriceDetail.DamagePrice.ToString().Replace(',', '.')}','{reservation.PriceDetail.ActualPrice.ToString().Replace(',', '.')}','{reservation.Status}')";
                _ReservationDBAcess.PostData(sql);

                //Set coupon id
                if (reservation.Coupon != null)
                {
                    sql = $"UPDATE `reservation` SET `CouponID`='{reservation.Coupon.CouponID}' WHERE `ReferenceNumber`='{reservation.ReferenceNumber}'";
                    _ReservationDBAcess.PostData(sql);
                }
                else
                {
                    sql = $"UPDATE `reservation` SET `CouponID`='0' WHERE `ReferenceNumber`='{reservation.ReferenceNumber}'";
                    _ReservationDBAcess.PostData(sql);
                }

                //Add address
                sql = $"INSERT INTO `renteeaddress`(`ReferenceNumber`, `Street`, `Zipcode`, `HouseNumber`, `City`, `PhoneNumber`) VALUES ('{reservation.ReferenceNumber}','{reservation.Address.StreetName}','{reservation.Address.ZipCode}','{reservation.Address.HouseNumber}','{reservation.Address.City}', '{reservation.PhoneNumber}')";
                _ReservationDBAcess.PostData(sql);

                //add rented items
                foreach (InventoryItem inv in reservation.InventoryItems)
                {
                    sql = $"INSERT INTO `renteditem`(`ReferenceNumber`, `InventoryItemID`) VALUES ('{reservation.ReferenceNumber}','{inv.InventoryID}')";
                    _ReservationDBAcess.PostData(sql);

                    //Set to inventory item to unavailable
                    inventoryItemController.UpdateInventoryItem(InventoryItemStatusCheck.InventoryItemStatusUpdate(inv));
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(Reservation reservation)
        {
            try
            {
                //remove reservation
                string sql = $"DELETE FROM `reservation` WHERE `ReferenceNumber`='{reservation.ReferenceNumber}'";
                _ReservationDBAcess.PostData(sql);

                //remove address
                sql = $"DELETE FROM `renteeaddress` WHERE `ReferenceNumber`='{reservation.ReferenceNumber}'";
                _ReservationDBAcess.PostData(sql);

                //remove rented items
                foreach (InventoryItem inv in reservation.InventoryItems)
                {
                    sql = $"DELETE FROM `renteditem` WHERE ReferenceNumber = {reservation.ReferenceNumber} AND InventoryItemID = {inv.InventoryID}";
                    _ReservationDBAcess.PostData(sql);

                    //Set to inventory item to available
                    inventoryItemController.UpdateInventoryItem(InventoryItemStatusCheck.InventoryItemStatusUpdate(inv));
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
