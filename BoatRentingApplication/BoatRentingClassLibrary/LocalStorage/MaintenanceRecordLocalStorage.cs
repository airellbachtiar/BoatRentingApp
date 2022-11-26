using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class MaintenanceRecordLocalStorage : IStorageOption<MaintenanceRecord>
    {
        public List<MaintenanceRecord> GetAll()
        {
            return TemporaryStorage.MaintenanceRecordList.Cast<MaintenanceRecord>().ToList();
        }

        public bool Add(MaintenanceRecord obj)
        {
            List<MaintenanceRecord> maintenanceRecords = GetAll();
            maintenanceRecords.Add(obj);
            TemporaryStorage.MaintenanceRecordList = maintenanceRecords;
            return true;
        }

        public bool Update(MaintenanceRecord obj)
        {
            List<MaintenanceRecord> maintenanceRecords = GetAll();

            //search and replace record
            for (int i = 0; i < maintenanceRecords.Count; i++)
            {
                if (maintenanceRecords[i].MaintenanceRecordID == obj.MaintenanceRecordID)
                {
                    maintenanceRecords[i] = obj;
                    break;
                }
            }

            TemporaryStorage.MaintenanceRecordList = maintenanceRecords;
            return true;
        }

        public bool Remove(MaintenanceRecord obj)
        {
            List<MaintenanceRecord> maintenanceRecords = GetAll();
            maintenanceRecords.Remove(obj);
            TemporaryStorage.MaintenanceRecordList = maintenanceRecords;
            return true;
        }
    }
}
