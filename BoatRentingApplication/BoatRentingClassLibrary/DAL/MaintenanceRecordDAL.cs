using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class MaintenanceRecordDAL : IStorageOption<MaintenanceRecord>
    {
        IStorageAccess _maintenanceRecordDBAcess;
        public MaintenanceRecordDAL(IStorageAccess dBAccessMaintenanceRecord)
        {
            _maintenanceRecordDBAcess = dBAccessMaintenanceRecord;
        }

        public List<MaintenanceRecord> GetAll()
        {
            try
            {
                List<MaintenanceRecord> maintenanceRecords = new List<MaintenanceRecord>();
                //get table from database
                string sql = "SELECT * FROM maintenance";
                DataTable dataTable = _maintenanceRecordDBAcess.GetData(sql);
                MaintenanceRecord maintenanceRecord;

                if (dataTable.Rows.Count != 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        //assign data from table
                        int inventoryItemID = Convert.ToInt32(row["InventoryItemID"].ToString());
                        int maintenanceRecordID = Convert.ToInt32(row["MaintenanceID"].ToString());
                        DateTime startDate = DateTime.Parse(row["StartDate"].ToString());
                        DateTime endDate = DateTime.Parse(row["EndDate"].ToString());

                        maintenanceRecord = new MaintenanceRecord(inventoryItemID, startDate, endDate);
                        maintenanceRecord.MaintenanceRecordID = maintenanceRecordID;

                        //Add to list
                        maintenanceRecords.Add(maintenanceRecord);
                    }
                }
                return maintenanceRecords;
            }
            catch (Exception)
            {
                return new List<MaintenanceRecord>();
            }
        }

        public bool Update(MaintenanceRecord maintenanceRecord)
        {
            try
            {
                //update to database
                string sql = $"UPDATE `maintenance` SET `InventoryItemID`='{maintenanceRecord.InventoryID}',`StartDate`='{DatabaseHelper.DateConverterToDB(maintenanceRecord.StartDate)}',`EndDate`='{DatabaseHelper.DateConverterToDB(maintenanceRecord.EndDate)}' WHERE `MaintenanceID`='{maintenanceRecord.MaintenanceRecordID}'";
                _maintenanceRecordDBAcess.PostData(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add(MaintenanceRecord maintenanceRecord)
        {
            try
            {
                //add to database
                string sql = $"INSERT INTO `maintenance`(`InventoryItemID`, `MaintenanceID`, `StartDate`, `EndDate`) VALUES ('{maintenanceRecord.InventoryID}','{maintenanceRecord.MaintenanceRecordID}','{DatabaseHelper.DateConverterToDB(maintenanceRecord.StartDate)}','{DatabaseHelper.DateConverterToDB(maintenanceRecord.EndDate)}')";
                _maintenanceRecordDBAcess.PostData(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(MaintenanceRecord maintenanceRecord)
        {
            try
            {
                //remove from database
                string sql = $"DELETE FROM `maintenance` WHERE `MaintenanceID`='{maintenanceRecord.MaintenanceRecordID}'";
                _maintenanceRecordDBAcess.PostData(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
