using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatRentingClassLibrary;

namespace BoatRentingDesktopApplication
{
    public partial class ItemFormEditInventoryItemPage : Form
    {
        HomePage HomePage;
        InventoryItemController inventoryItemController;
        InventoryItem editInventoryItem;
        ItemController itemController;
        MaintenanceRecordController maintenanceRecordController;

        public ItemFormEditInventoryItemPage(HomePage homePage, InventoryItem inventoryItem)
        {
            InitializeComponent();
            HomePage = homePage;
            inventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            itemController = new ItemController(new ItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            if (inventoryItem is InventoryBoat)
            {
                maintenanceRecordController = new MaintenanceRecordController(new MaintenanceRecordDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            }
            this.editInventoryItem = inventoryItemController.GetAllInventoryItem().Where(inv => inv.InventoryID == inventoryItem.InventoryID).FirstOrDefault();
            InitializeInventoryItem(editInventoryItem);
        }

        //Setup data from datatype to input
        private void InitializeInventoryItem(InventoryItem inventoryItem)
        {
            grpbxMaintenanceRecord.Hide();
            List<Item> itemsForComboBox = itemController.GetAllItem();
            if (itemsForComboBox != null)
            {
                foreach (Item it in itemController.GetAllItem())
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append(it.ItemID);
                    stringBuilder.Append('-');
                    stringBuilder.Append(it.Name);
                    cbxItemList.Items.Add(stringBuilder.ToString());
                }

                StringBuilder sb = new StringBuilder();
                sb.Append(editInventoryItem.Item.ItemID);
                sb.Append('-');
                sb.Append(editInventoryItem.Item.Name);
                cbxItemList.SelectedItem = sb.ToString();
            }

            chbxIsBoat.Enabled = false;

            //if inventory item is a boat
            if (inventoryItem is InventoryBoat)
            {
                grpbxMaintenanceRecord.Show();
                dgvMaintenanceRecords.DataSource = null;
                dgvMaintenanceRecords.Rows.Clear();
                dgvMaintenanceRecords.DataSource = ((InventoryBoat)inventoryItem).MaintenanceRecords;
                chbxIsBoat.Checked = true;
                nudBoatCapacity.Value = ((InventoryBoat)inventoryItem).Capacity;
            }
        }
        
        private void btnEditInventory_Click(object sender, EventArgs e)
        {
            //check input validation
            if (ValidateInventoryItem())
            {
                string itemFromComboBox = cbxItemList.SelectedItem.ToString();
                string[] seperatedItemFromComboBox = itemFromComboBox.Split('-');
                int itemID = Convert.ToInt32(seperatedItemFromComboBox[0]);

                //get item to be assigned
                Item assignedItem = itemController.GetItem(itemID);

                if (assignedItem != null)
                {
                    editInventoryItem.Item = assignedItem;
                    if (editInventoryItem is InventoryBoat)
                    {
                        int capacity = Convert.ToInt32(nudBoatCapacity.Value);
                        ((InventoryBoat)editInventoryItem).Capacity = capacity;
                    }

                    if (inventoryItemController.UpdateInventoryItem(editInventoryItem))
                    {
                        MessageBox.Show("Successfully edited");
                    }
                    else
                        MessageBox.Show("Failed to edit");
                }
                else
                    MessageBox.Show("Error");
            }
        }

        private void btnRemoveInventory_Click(object sender, EventArgs e)
        {
            if (inventoryItemController.RemoveInventoryItem(editInventoryItem))
            {
                MessageBox.Show("Inventory item removed");
                HomePage.ShowItemPage();
            }
            else
                MessageBox.Show("Failed to remove");
        }

        private bool ValidateInventoryItem()
        {
            bool result = true;
            //check if item is not selected
            if (cbxItemList.SelectedItem == null)
            {
                MessageBox.Show("Choose Item");
                result = false;
            }
            return result;
        }

        private void btnAddMaintenanceRecord_Click(object sender, EventArgs e)
        {
            if (editInventoryItem is InventoryBoat)
            {
                HomePage.ShowAddMaintenanceRecord((InventoryBoat)editInventoryItem);
            }
            else
                MessageBox.Show("Error");
        }

        private void btnEditMaintenanceRecord_Click(object sender, EventArgs e)
        {
            if (editInventoryItem is InventoryBoat && dgvMaintenanceRecords.CurrentRow != null)
            {
                int maintenanceRecordID = Convert.ToInt32(dgvMaintenanceRecords.CurrentRow.Cells[1].Value);
                MaintenanceRecord maintenanceRecord = maintenanceRecordController.GetAllMaintenanceRecords().Where(m => m.MaintenanceRecordID == maintenanceRecordID).FirstOrDefault();
                HomePage.ShowEditMaintenanceRecord((InventoryBoat)editInventoryItem, maintenanceRecord);
            }
            else
                MessageBox.Show("Error");
        }
    }
}
