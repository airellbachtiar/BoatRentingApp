using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class CouponDAL : IStorageOption<Coupon>
    {
        IStorageAccess _couponDBAccess;
        public CouponDAL(IStorageAccess dBAccessCoupon)
        {

            _couponDBAccess = dBAccessCoupon;
        }

        public List<Coupon> GetAll()
        {
            try
            {
                List<Coupon> coupons = new List<Coupon>();
                //Get table from database
                string sql = $"SELECT * FROM `coupon` LEFT OUTER JOIN exclusivecoupon ON coupon.CouponID = exclusivecoupon.CouponID LEFT OUTER JOIN limitedcoupon ON coupon.CouponID = limitedcoupon.CouponID LEFT OUTER JOIN timecoupon ON coupon.CouponID = timecoupon.CouponID";
                DataTable dataTable = _couponDBAccess.GetData(sql);

                //Check if database is present
                if (dataTable.Rows.Count != 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        //Assign data from table
                        int couponID = Convert.ToInt32(row["CouponID"].ToString());
                        string code = row["Code"].ToString();
                        int discount = Convert.ToInt32(row["Discount"].ToString());
                        string customerIDStr = DatabaseHelper.DBNullConverter(row["CustomerID"].ToString());
                        string totalUsesStr = DatabaseHelper.DBNullConverter(row["TotalUses"].ToString());
                        string endDateStr = DatabaseHelper.DBNullConverter(row["EndDate"].ToString());

                        Coupon coupon = new Coupon(code, discount);

                        //Check which coupon to assign
                        if (customerIDStr != null)
                        {
                            ExclusiveCoupon exclusiveCoupon = new ExclusiveCoupon(coupon, Convert.ToInt32(customerIDStr));
                            exclusiveCoupon.IsRedeeemed = Convert.ToBoolean(row["IsRedeemed"]);
                            exclusiveCoupon.CouponID = couponID;

                            //Add to list
                            coupons.Add(exclusiveCoupon);
                        }
                        else if (totalUsesStr != null)
                        {
                            LimitedCoupon limitedCoupon = new LimitedCoupon(coupon, Convert.ToInt32(totalUsesStr));
                            limitedCoupon.RemainingUses = Convert.ToInt32(row["RemainingUses"].ToString());
                            limitedCoupon.CouponID = couponID;

                            //Add to list
                            coupons.Add(limitedCoupon);
                        }
                        else if (endDateStr != null)
                        {
                            TimeCoupon timeCoupon = new TimeCoupon(coupon, DateTime.Parse(endDateStr));
                            timeCoupon.CouponID = couponID;

                            //Add to list
                            coupons.Add(timeCoupon);
                        }
                    }
                }
                return coupons;
            }
            catch (Exception)
            {
                return new List<Coupon>();
            }
        }

        public bool Update(Coupon coupon)
        {
            try
            {
                //Update database
                string sql = $"UPDATE `coupon` SET `Code`='{coupon.Code}',`Discount`='{coupon.Discount}' WHERE `CouponID`='{coupon.CouponID}'";
                _couponDBAccess.PostData(sql);
                
                //Base on coupon type, additional changes to database for different table is necessary
                if (coupon is ExclusiveCoupon)
                {
                    sql = $"UPDATE `exclusivecoupon` SET `CustomerID`='{((ExclusiveCoupon)coupon).CustomerID}',`IsRedeemed`='{DatabaseHelper.BoolConverterToDB(((ExclusiveCoupon)coupon).IsRedeeemed)}' WHERE `CouponID`='{coupon.CouponID}'";
                    _couponDBAccess.PostData(sql);
                }
                else if (coupon is LimitedCoupon)
                {
                    sql = $"UPDATE `limitedcoupon` SET `TotalUses`='{((LimitedCoupon)coupon).TotalUses}',`RemainingUses`='{((LimitedCoupon)coupon).RemainingUses}' WHERE `CouponID`='{coupon.CouponID}'";
                    _couponDBAccess.PostData(sql);
                }
                else if (coupon is TimeCoupon)
                {
                    sql = $"UPDATE `timecoupon` SET `EndDate`='{DatabaseHelper.DateConverterToDB(((TimeCoupon)coupon).EndDate)}' WHERE `CouponID`='{coupon.CouponID}'";
                    _couponDBAccess.PostData(sql);
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool Add(Coupon coupon)
        {
            try
            {
                //Add coupon to database
                string sql = $"INSERT INTO `coupon`(`CouponID`, `Code`, `Discount`) VALUES ('{coupon.CouponID}','{coupon.Code}','{coupon.Discount}')";
                _couponDBAccess.PostData(sql);

                //Base on coupon type, additional command for different table is necessary
                if (coupon is ExclusiveCoupon)
                {
                    sql = $"INSERT INTO `exclusivecoupon`(`CouponID`, `CustomerID`, `IsRedeemed`) VALUES ('{coupon.CouponID}','{((ExclusiveCoupon)coupon).CustomerID}','{DatabaseHelper.BoolConverterToDB(((ExclusiveCoupon)coupon).IsRedeeemed)}')";
                    _couponDBAccess.PostData(sql);
                }
                else if (coupon is LimitedCoupon)
                {
                    sql = $"INSERT INTO `limitedcoupon`(`CouponID`, `TotalUses`, `RemainingUses`) VALUES ('{coupon.CouponID}','{((LimitedCoupon)coupon).TotalUses}','{((LimitedCoupon)coupon).RemainingUses}')";
                    _couponDBAccess.PostData(sql);
                }
                else if (coupon is TimeCoupon)
                {
                    sql = $"INSERT INTO `timecoupon`(`CouponID`, `EndDate`) VALUES ('{coupon.CouponID}','{DatabaseHelper.DateConverterToDB(((TimeCoupon)coupon).EndDate)}')";
                    _couponDBAccess.PostData(sql);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(Coupon coupon)
        {
            try
            {
                //Remove coupon from database
                string sql = $"DELETE FROM `coupon` WHERE `CouponID`='{coupon.CouponID}'";
                _couponDBAccess.PostData(sql);

                //Remove coupon on different table based on coupon type
                if (coupon is ExclusiveCoupon)
                {
                    sql = $"DELETE FROM `exclusivecoupon` WHERE `CouponID`='{coupon.CouponID}'";
                    _couponDBAccess.PostData(sql);
                }
                else if (coupon is LimitedCoupon)
                {
                    sql = $"DELETE FROM `limitedcoupon` WHERE `CouponID`='{coupon.CouponID}'";
                    _couponDBAccess.PostData(sql);
                }
                else if (coupon is TimeCoupon)
                {
                    sql = $"DELETE FROM `timecoupon` WHERE `CouponID`='{coupon.CouponID}'";
                    _couponDBAccess.PostData(sql);
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
