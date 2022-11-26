using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class InventoryBoat : InventoryItem
    {
        public InventoryBoat(Item item, int capacity) : base(item)
        {
            this.Capacity = capacity;
            maintenanceRecords = new List<MaintenanceRecord>();
        }

        private List<MaintenanceRecord> maintenanceRecords;

        public int Capacity { get; set; }
        public List<MaintenanceRecord> MaintenanceRecords { get {return maintenanceRecords; } set { maintenanceRecords = value;} }
    }
}
