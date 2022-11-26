using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public static class InventoryItemStatusCheck
    {
        public static InventoryItem InventoryItemStatusUpdate(InventoryItem inventoryItem) 
        {
            ReservationController reservationController = new ReservationController(new ReservationDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            List<Reservation> reservations = reservationController.GetAllReservation();

            //update inventory item
            InventoryItemController inventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            InventoryItem inventory = inventoryItemController.GetInventoryItem(inventoryItem.InventoryID);

            //Check reservation
            if (reservations.Count != 0)
            {
                foreach (Reservation r in reservations)
                {
                    foreach (InventoryItem inv in r.InventoryItems)
                    {
                        if (inv.InventoryID == inventory.InventoryID)
                        {
                            inventory.Status = "Rented";
                            inventory.IsAvailable = false;
                            return inventory;
                        }
                    }
                }
            }

            //inventory is boat
            if (inventory is InventoryBoat)
            {
                //convert to inventory boat
                InventoryBoat boat = (InventoryBoat)inventory;

                if (boat.MaintenanceRecords.Count != 0)
                {
                    foreach (MaintenanceRecord m in boat.MaintenanceRecords)
                    {
                        if (m.StartDate < DateTime.Now && m.EndDate > DateTime.Now)
                        {
                            boat.Status = "On_Maintenance";
                            boat.IsAvailable = false;
                            return boat;
                        }
                    }
                }
            }

            inventory.Status = "Available";
            inventory.IsAvailable = true;
            return inventory;
        }
    }
}
