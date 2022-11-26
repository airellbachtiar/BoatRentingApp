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
    public partial class ItemFormPage : Form
    {
        HomePage HomePage;
        ItemController itemController;
        InventoryItemController inventoryItemController;

        public ItemFormPage(HomePage homePage)
        {
            InitializeComponent();
            HomePage = homePage;
            itemController = new ItemController(new ItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            inventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            UpdateItemComboBox();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //check input validation
            if (ValidateAddItem())
            {
                //convert input to datatype
                string name = tbxItemName.Text;
                double cost = Convert.ToDouble(nudItemCost.Value);
                double deposit = Convert.ToDouble(nudItemDeposit.Value);
                string description = rtbxItemDescription.Text;
                bool isBoat = chbxIsBoatItem.Checked;

                Item newItem = new Item(name, cost, deposit, description, isBoat);

                //check if item can be added
                if (itemController.AddItem(newItem))
                {
                    MessageBox.Show("Successfully added");
                }
                else
                    MessageBox.Show("Fail to add");

                //update combobox for new entry
                UpdateItemComboBox();
            }
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            //check input validation
            if (ValidateAddInventoryItem())
            {
                //convert input to datatype
                string itemFromComboBox = cbxItemList.SelectedItem.ToString();
                string[] seperatedItemFromComboBox = itemFromComboBox.Split('-');
                int itemID = Convert.ToInt32(seperatedItemFromComboBox[0]);
                int amount = Convert.ToInt32(nudInventoryAmount.Value);
                int capacity = 1;

                //get item
                Item assignedItem = itemController.GetItem(itemID);

                //check if item is avaiable
                if (assignedItem != null)
                {
                    //if item is boat
                    if (chbxIsBoat.Checked && assignedItem.IsBoat == chbxIsBoat.Checked)
                    {
                        capacity = Convert.ToInt32(nudBoatCapacity.Value);
                    }

                    //add inventory item based on number of amount
                    for (int i = 0; i < amount; i++)
                    {
                        if (chbxIsBoat.Checked && assignedItem.IsBoat == chbxIsBoat.Checked)
                        {
                            inventoryItemController.AddInventoryItem(new InventoryBoat(assignedItem, capacity));
                        }
                        else
                        {
                            inventoryItemController.AddInventoryItem(new InventoryItem(assignedItem));
                        }
                    }
                    MessageBox.Show("Items have been added");
                }
                else
                    MessageBox.Show("Item not found");
            }
        }

        private void UpdateItemComboBox()
        {
            cbxItemList.Items.Clear();
            List<Item> itemsForComboBox = itemController.GetAllItem();
            if (itemsForComboBox != null)
            {
                //add item based with format
                foreach (Item it in itemController.GetAllItem())
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append(it.ItemID);
                    stringBuilder.Append('-');
                    stringBuilder.Append(it.Name);
                    cbxItemList.Items.Add(stringBuilder.ToString());
                }
                cbxItemList.SelectedIndex = 0;
            }
        }

        //check validation for adding item
        private bool ValidateAddItem()
        {
            bool result = true;
            if (string.IsNullOrEmpty(tbxItemName.Text))
            {
                MessageBox.Show("Insert Name");
                result = false;
            }
            return result;
        }

        //check validation for adding inventory item
        private bool ValidateAddInventoryItem()
        {
            bool result = true;
            if (cbxItemList.SelectedItem == null)
            {
                MessageBox.Show("Choose Item");
                result = false;
            }
            return result;
        }

        private void cbxItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get item id
            string itemFromComboBox = cbxItemList.SelectedItem.ToString();
            string[] seperatedItemFromComboBox = itemFromComboBox.Split('-');
            int itemID = Convert.ToInt32(seperatedItemFromComboBox[0]);

            //Get item
            Item assignedItem = itemController.GetItem(itemID);

            if (assignedItem.IsBoat)
            {
                chbxIsBoat.Checked = true;
            }
            else
            {
                chbxIsBoat.Checked = false;
            }
        }

        private void chbxIsBoat_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxIsBoat.Checked)
            {
                nudBoatCapacity.Enabled = true;
            }
            else
            {
                nudBoatCapacity.Enabled = false;
            }
        }
    }
}
