using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class ItemDAL : IStorageOption<Item>
    {
        IStorageAccess _ItemDBAcess;
        public ItemDAL(IStorageAccess dBAccessItem)
        {
            _ItemDBAcess = dBAccessItem;
        }

        public List<Item> GetAll()
        {
            try
            {
                List<Item> items = new List<Item>();
                //get table from database
                string sql = "SELECT * FROM item";
                DataTable dataTable = _ItemDBAcess.GetData(sql);
                if (dataTable.Rows.Count != 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        //assign data
                        int itemID = Convert.ToInt32(row["ItemID"].ToString());
                        string name = row["Name"].ToString();
                        double cost = Convert.ToDouble(row["Cost"].ToString());
                        double deposit = Convert.ToDouble(row["Deposit"].ToString());
                        string description = row["Description"].ToString();
                        bool isBoat = Convert.ToBoolean(row["IsBoat"].ToString());

                        Item item = new Item(name, cost, deposit, description, isBoat);
                        item.ItemID = itemID;

                        //add to list
                        items.Add(item);
                    }
                }
                return items;
            }
            catch (Exception)
            {
                return new List<Item>();
            }
        }

        public bool Update(Item item)
        {
            try
            {
                //Change format for database
                string cost = item.Cost.ToString().Replace(',', '.');
                string deposit = item.Deposit.ToString().Replace(',', '.');

                //update to database
                string sql = $"UPDATE `item` SET `Name`='{item.Name}',`Cost`='{cost}',`Deposit`='{deposit}',`Description`='{item.Description}',`IsBoat`='{DatabaseHelper.BoolConverterToDB(item.IsBoat)}' WHERE `ItemID` = {item.ItemID}";
                _ItemDBAcess.PostData(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add(Item item)
        {
            try
            {
                //change format for database
                string cost = item.Cost.ToString().Replace(',', '.');
                string deposit = item.Deposit.ToString().Replace(',', '.');

                //Add to database
                string sql = $"INSERT INTO `item`(`ItemID`, `Name`, `Cost`, `Deposit`, `Description`, `IsBoat`) VALUES ('{item.ItemID}','{item.Name}','{cost}','{deposit}','{item.Description}','{DatabaseHelper.BoolConverterToDB(item.IsBoat)}')";
                _ItemDBAcess.PostData(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(Item item)
        {
            try
            {
                //Remove from database
                string sql = $"DELETE FROM `item` WHERE `ItemID` = {item.ItemID}";
                _ItemDBAcess.PostData(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
