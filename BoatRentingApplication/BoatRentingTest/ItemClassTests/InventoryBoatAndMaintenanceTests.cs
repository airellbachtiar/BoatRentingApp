using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoatRentingClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoatRentingTest.ItemClassTests
{
    [TestClass]
    public class InventoryBoatAndMaintenanceTests
    {
        Item BoatItem = new Item("BoatItemForInventory", 3d, 3d, "", true);
        InventoryItemController inventoryItemController = new InventoryItemController(new InventoryItemLocalStorage());
        ItemController itemController = new ItemController(new ItemLocalStorage());
        MaintenanceRecordController maintenanceRecordController = new MaintenanceRecordController(new MaintenanceRecordLocalStorage());

        public InventoryBoatAndMaintenanceTests()
        {
            TemporaryStorage.InventoryItemList = new List<InventoryItem>();
            TemporaryStorage.ItemList = new List<Item>();
            TemporaryStorage.MaintenanceRecordList = new List<MaintenanceRecord>();
        }

        [TestMethod]
        public void A_AddInventoryBoat_ReturnAddedInventoryItem()
        {
            itemController.AddItem(BoatItem);
            InventoryBoat inventoryBoat = new InventoryBoat(BoatItem, 5);
            inventoryItemController.AddInventoryItem(inventoryBoat);
            InventoryItem addedInventoryboat = inventoryItemController.GetAllInventoryItem().Last();

            Assert.AreEqual(BoatItem, inventoryBoat.Item);
        }

        [TestMethod]
        public void B_UpdateInventoryBoat_ReturnTrue()
        {
            itemController.AddItem(BoatItem);
            InventoryBoat inventoryBoat = new InventoryBoat(BoatItem, 5);
            inventoryItemController.AddInventoryItem(inventoryBoat);
            InventoryItem addedInventoryboat = inventoryItemController.GetAllInventoryItem().Last();

            InventoryItem inventoryItem = inventoryItemController.GetAllInventoryItem().Last();
            inventoryItem.Status = "Rented";
            Assert.IsTrue(inventoryItemController.UpdateInventoryItem(inventoryItem));
        }

        public void C_AddMaintenance_ReturnTrue()
        {
            itemController.AddItem(BoatItem);
            InventoryBoat inventoryBoat = new InventoryBoat(BoatItem, 5);
            inventoryItemController.AddInventoryItem(inventoryBoat);
            InventoryItem addedInventoryboat = inventoryItemController.GetAllInventoryItem().Last();

            inventoryBoat = (InventoryBoat)inventoryItemController.GetAllInventoryItem().Last();
            MaintenanceRecord maintenanceRecord = new MaintenanceRecord(inventoryBoat.InventoryID, DateTime.Parse("25-12-2021"), DateTime.Parse("27-12-2021"));
            Assert.IsTrue(maintenanceRecordController.AddMaintenanceRecord(maintenanceRecord, inventoryBoat));
        }

        public void D_UpdateMaintenance_ReturnTrue()
        {
            itemController.AddItem(BoatItem);
            InventoryBoat inventoryBoat = new InventoryBoat(BoatItem, 5);
            inventoryItemController.AddInventoryItem(inventoryBoat);
            InventoryItem addedInventoryboat = inventoryItemController.GetAllInventoryItem().Last();

            inventoryBoat = (InventoryBoat)inventoryItemController.GetAllInventoryItem().Last();
            MaintenanceRecord maintenanceRecord = new MaintenanceRecord(inventoryBoat.InventoryID, DateTime.Parse("25-12-2021"), DateTime.Parse("27-12-2021"));
            maintenanceRecordController.AddMaintenanceRecord(maintenanceRecord, inventoryBoat);

            inventoryBoat = (InventoryBoat)inventoryItemController.GetAllInventoryItem().Last();
            maintenanceRecord = inventoryBoat.MaintenanceRecords.Last();
            maintenanceRecord.EndDate = DateTime.Parse("28-12-2021");

            Assert.IsTrue(maintenanceRecordController.UpdateMaintenanceRecord(maintenanceRecord, inventoryBoat));
        }

        [TestMethod]
        public void E_RemoveInventoryBoat_ReturnNull()
        {
            itemController.AddItem(BoatItem);
            InventoryBoat inventoryBoat = new InventoryBoat(BoatItem, 5);
            inventoryItemController.AddInventoryItem(inventoryBoat);
            InventoryItem addedInventoryboat = inventoryItemController.GetAllInventoryItem().Last();

            inventoryBoat = (InventoryBoat)inventoryItemController.GetAllInventoryItem().Last();
            itemController.RemoveItem(GetItem(BoatItem.Name));

            Assert.IsTrue(inventoryItemController.RemoveInventoryItem(inventoryBoat));
        }

        private Item GetItem(string name)
        {
            foreach (Item i in itemController.GetAllItem())
            {
                if (i.Name == name)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
