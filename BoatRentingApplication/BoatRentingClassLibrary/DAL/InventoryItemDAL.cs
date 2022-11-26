using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class InventoryItemDAL : IStorageOption<InventoryItem>
    {
        IStorageAccess _inventoryItemDBAcess;
        public InventoryItemDAL(IStorageAccess dBAccessInventoryItem)
        {
            _inventoryItemDBAcess = dBAccessInventoryItem;
        }

        public List<InventoryItem> GetAll()
        {
            try
            {
                List<InventoryItem> inventoryItems = new List<InventoryItem>();
                //get table from database
                string sql = "SELECT * FROM `inventoryitem` LEFT OUTER JOIN inventoryboat on inventoryitem.InventoryItemID = inventoryboat.InventoryBoatID";
                DataTable dataTable = _inventoryItemDBAcess.GetData(sql);

                //Create controller for list of necessary data
                ItemController itemController= new ItemController(new ItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
                MaintenanceRecordController maintenanceRecordController = new MaintenanceRecordController(new MaintenanceRecordDAL(new DBAccess(DatabaseHelper.mainDatabase)));

                //List of items and maintenance record
                List<Item> items = itemController.GetAllItem();
                List<MaintenanceRecord> maintenanceRecords = maintenanceRecordController.GetAllMaintenanceRecords();

                if (dataTable.Rows.Count != 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        //Assign basic data
                        int itemID = Convert.ToInt32(row["ItemID"].ToString());
                        Item item = items.Where(i => i.ItemID == itemID).FirstOrDefault();
                        int inventoryItemID = Convert.ToInt32(row["InventoryItemID"].ToString());
                        string status = row["Status"].ToString();
                        bool isAvailable = Convert.ToBoolean(row["IsAvailable"].ToString());
                        string capacityStr = DatabaseHelper.DBNullConverter(row["Capacity"].ToString());

                        InventoryItem inventoryItem;
                        //Check if item is present
                        if (item != null)
                        {
                            //Check if item is boat or not
                            if (capacityStr != null)
                            {
                                int capacity = Convert.ToInt32(capacityStr);
                                inventoryItem = new InventoryBoat(item, capacity);
                                //Get maintenance record for item boat
                                ((InventoryBoat)inventoryItem).MaintenanceRecords = maintenanceRecords.Where(m => m.InventoryID == inventoryItemID).ToList();
                            }
                            else
                            {
                                inventoryItem = new InventoryItem(item);
                            }

                            inventoryItem.InventoryID = inventoryItemID;
                            inventoryItem.Status = status;
                            inventoryItem.IsAvailable = isAvailable;

                            //Add item to list
                            inventoryItems.Add(inventoryItem);
                        }
                    }
                }
                return inventoryItems;
            }
            catch (Exception)
            {
                return new List<InventoryItem>();
            }
        }

        public bool Update(InventoryItem inventoryItem)
        {
            try
            {
                //Update to database
                string sql = $"UPDATE `inventoryitem` SET `ItemID`='{inventoryItem.Item.ItemID}', `Status`='{inventoryItem.Status}',`IsAvailable`='{DatabaseHelper.BoolConverterToDB(inventoryItem.IsAvailable)}' WHERE `InventoryItemID`='{inventoryItem.InventoryID}'";
                _inventoryItemDBAcess.PostData(sql);

                //Additional command to update boat
                if (inventoryItem is InventoryBoat)
                {
                    sql = $"UPDATE `inventoryboat` SET `ItemID`='{inventoryItem.Item.ItemID}',`Capacity`='{((InventoryBoat)inventoryItem).Capacity}' WHERE `InventoryBoatID`='{inventoryItem.InventoryID}'";
                    _inventoryItemDBAcess.PostData(sql);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add(InventoryItem inventoryItem)
        {
            try
            {
                //Add to database
                string sql = $"INSERT INTO `inventoryitem`(`ItemID`, `InventoryItemID`, `Status`, `IsAvailable`) VALUES ('{inventoryItem.Item.ItemID}','{inventoryItem.InventoryID}','{inventoryItem.Status}','{DatabaseHelper.BoolConverterToDB(inventoryItem.IsAvailable)}')";
                _inventoryItemDBAcess.PostData(sql);

                //Additional command to add a column in different table for boat
                if (inventoryItem is InventoryBoat)
                {
                    sql = $"INSERT INTO `inventoryboat`(`ItemID`, `InventoryBoatID`, `Capacity`) VALUES ('{inventoryItem.Item.ItemID}','{inventoryItem.InventoryID}','{((InventoryBoat)inventoryItem).Capacity}')";
                    _inventoryItemDBAcess.PostData(sql);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(InventoryItem inventoryItem)
        {
            try
            {
                //remove from database
                string sql = $"DELETE FROM `inventoryitem` WHERE `InventoryItemID`='{inventoryItem.InventoryID}'";
                _inventoryItemDBAcess.PostData(sql);

                //remove data from table boat and remove maintenance record
                if (inventoryItem is InventoryBoat)
                {
                    sql = $"DELETE FROM `maintenance` WHERE `InventoryItemID` = {inventoryItem.InventoryID}";
                    _inventoryItemDBAcess.PostData(sql);
                    sql = $"DELETE FROM `inventoryboat` WHERE `InventoryBoatID` = {inventoryItem.InventoryID}";
                    _inventoryItemDBAcess.PostData(sql);
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
