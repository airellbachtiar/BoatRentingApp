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
    public partial class ItemPage : Form
    {
        HomePage HomePage;
        ItemController itemController;
        InventoryItemController inventoryItemController;

        //for viewing item or inventory item
        bool isViewItem;

        public ItemPage(HomePage homePage)
        {
            InitializeComponent();
            HomePage = homePage;
            itemController = new ItemController(new ItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            inventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            UpdateDataGridView(true);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            HomePage.ShowItemFormPage();
        }

        private void btnViewItem_Click(object sender, EventArgs e)
        {
            UpdateDataGridView(true);
        }

        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            UpdateDataGridView(false);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dgvItemPage.CurrentRow.Cells[0].Value);

            //if item is shown
            if (isViewItem)
            {
                Item selectedItem = itemController.GetItem(selectedID);
                if (selectedItem != null)
                {
                    HomePage.ShowEditItemForm(selectedItem);
                }
            }
            //if inventory item is shown
            else
            {
                InventoryItem selectedInventoryItem = inventoryItemController.GetInventoryItem(selectedID);
                if (selectedInventoryItem != null)
                {
                    HomePage.ShowEditInventoryItemForm(selectedInventoryItem);
                }
            }
        }

        //update data grid view based on true and false of isItem, if true, item is shown
        private void UpdateDataGridView(bool isItem)
        {
            dgvItemPage.DataSource = null;
            dgvItemPage.Columns.Clear();

            isViewItem = isItem;
            if (isViewItem)
            {
                dgvItemPage.DataSource = itemController.GetAllItem();
            }
            else
            {
                dgvItemPage.ColumnCount = 5;
                dgvItemPage.Columns[0].Name = "ID";
                dgvItemPage.Columns[1].Name = "Status";
                dgvItemPage.Columns[2].Name = "Is Available";
                dgvItemPage.Columns[3].Name = "Item Name";
                dgvItemPage.Columns[4].Name = "Is Boat";

                foreach(InventoryItem inv in inventoryItemController.GetAllInventoryItem())
                {
                    dgvItemPage.Rows.Add(inv.InventoryID, inv.Status, inv.IsAvailable, inv.Item.Name, inv.Item.IsBoat);
                }
            }
        }
    }
}
