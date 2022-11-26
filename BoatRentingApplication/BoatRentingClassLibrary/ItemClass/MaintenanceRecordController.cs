using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class MaintenanceRecordController
    {
        private List<MaintenanceRecord> maintenanceRecords;
        private IStorageOption<MaintenanceRecord> maintenanceRecordDAL;

        public MaintenanceRecordController(IStorageOption<MaintenanceRecord> maintenanceRecordDAL)
        {
            this.maintenanceRecordDAL = maintenanceRecordDAL;
        }

        public List<MaintenanceRecord> GetAllMaintenanceRecords()
        {
            maintenanceRecords = maintenanceRecordDAL.GetAll();
            return maintenanceRecords;
        }

        public bool AddMaintenanceRecord(MaintenanceRecord maintenanceRecord, InventoryBoat inventoryBoat)
        {
            //refresh maintenance
            maintenanceRecords = GetAllMaintenanceRecords();

            //assign id
            if (maintenanceRecords.Count != 0)
            {
                //assign highest id and add 1
                int highestID = maintenanceRecords.Max(maintenanceRecord => maintenanceRecord.MaintenanceRecordID);
                maintenanceRecord.MaintenanceRecordID = ++highestID;
            }
            else
            {
                //assign 1 if it's the first entry
                maintenanceRecord.MaintenanceRecordID = 1;
            }

            if (maintenanceRecordDAL.Add(maintenanceRecord))
            {
                //Update inventory boat
                inventoryBoat.MaintenanceRecords.Add(maintenanceRecord);
                InventoryItemController inventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
                return inventoryItemController.UpdateInventoryItem((InventoryBoat)InventoryItemStatusCheck.InventoryItemStatusUpdate(inventoryBoat));
            }
            else
            {
                return false;
            }
        }

        public bool UpdateMaintenanceRecord(MaintenanceRecord maintenanceRecord, InventoryBoat inventoryBoat)
        {
            if (maintenanceRecordDAL.Update(maintenanceRecord))
            {
                InventoryItemController inventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
                return inventoryItemController.UpdateInventoryItem((InventoryBoat)InventoryItemStatusCheck.InventoryItemStatusUpdate(inventoryBoat));
            }
            else
            {
                return false;
            }
        }

        public bool RemoveMaintenanceRecord(MaintenanceRecord maintenanceRecord, InventoryBoat inventoryBoat)
        {
            if (maintenanceRecordDAL.Remove(maintenanceRecord))
            {
                InventoryItemController inventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
                return inventoryItemController.UpdateInventoryItem((InventoryBoat)InventoryItemStatusCheck.InventoryItemStatusUpdate(inventoryBoat));
            }
            else
            {
                return false;
            }
        }
    }
}
