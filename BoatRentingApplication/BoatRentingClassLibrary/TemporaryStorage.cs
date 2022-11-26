using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public static class TemporaryStorage
    {
        static TemporaryStorage()
        {
            if(EmployeeList == null)
            {
                EmployeeList = new List<Employee>();
            }

            if (CustomerList == null)
            {
                CustomerList = new List<Customer>();
            }

            if (CouponList == null)
            {
                CouponList = new List<Coupon>();
            }

            if (InventoryItemList == null)
            {
                InventoryItemList = new List<InventoryItem>();
            }

            if (ItemList == null)
            {
                ItemList = new List<Item>();
            }

            if (MaintenanceRecordList == null)
            {
                MaintenanceRecordList = new List<MaintenanceRecord>();
            }

            if (ReservationList == null)
            {
                ReservationList = new List<Reservation>();
            }
        }

        public static IList<Employee> EmployeeList { get; set; }
        public static IList<Customer> CustomerList { get; set; }
        public static IList<Coupon> CouponList { get; set; }
        public static IList<InventoryItem> InventoryItemList { get; set; }
        public static IList<Item> ItemList { get; set; }
        public static IList<MaintenanceRecord> MaintenanceRecordList { get; set; }
        public static IList<Reservation> ReservationList { get; set; }
    }
}
