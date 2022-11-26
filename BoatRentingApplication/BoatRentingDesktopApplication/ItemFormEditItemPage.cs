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
    public partial class ItemFormEditItemPage : Form
    {
        HomePage HomePage;
        ItemController itemController;
        Item editItem;

        public ItemFormEditItemPage(HomePage homePage, Item item)
        {
            InitializeComponent();
            HomePage = homePage;
            itemController = new ItemController(new ItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            this.editItem = item;
            InitializeItem();
        }

        //fill in input
        private void InitializeItem()
        {
            tbxItemName.Text = editItem.Name;
            nudItemCost.Value = Convert.ToDecimal(editItem.Cost);
            nudItemDeposit.Value = Convert.ToDecimal(editItem.Deposit);
            rtbxItemDescription.Text = editItem.Description;
        }

        //check input
        private bool ValidateItem()
        {
            bool result = true;

            //check if input is empty
            if (string.IsNullOrEmpty(tbxItemName.Text))
            {
                MessageBox.Show("Insert Name");
                result = false;
            }
            return result;
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            //validate input
            if (ValidateItem())
            {
                //convert input to datatype
                string name = tbxItemName.Text;
                double cost = Convert.ToDouble(nudItemCost.Value);
                double deposit = Convert.ToDouble(nudItemDeposit.Value);
                string description = rtbxItemDescription.Text;

                editItem.Name = name;
                editItem.Cost = cost;
                editItem.Deposit = deposit;
                editItem.Description = description;

                //check if update is successfull
                if (itemController.UpdateItem(editItem))
                {
                    MessageBox.Show("Successfully update item");
                }
                else
                    MessageBox.Show("Failed to edit");
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            //check if item is removed
            if (itemController.RemoveItem(editItem))
            {
                MessageBox.Show("Item removed");
                HomePage.ShowItemPage();
            }
            else
                MessageBox.Show("Failed to remove");
        }
    }
}
