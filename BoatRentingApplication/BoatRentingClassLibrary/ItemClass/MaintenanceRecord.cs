using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class MaintenanceRecord
    {
        public MaintenanceRecord(int inventoryID, DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.InventoryID = inventoryID;
        }
        public int InventoryID { get; set; }
        public int MaintenanceRecordID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
