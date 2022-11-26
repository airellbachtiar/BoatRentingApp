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
    public partial class MaintenanceRecordFormPage : Form
    {
        HomePage HomePage;
        InventoryItemController inventoryItemController;
        InventoryBoat inventoryBoat;
        MaintenanceRecord maintenanceRecord;
        MaintenanceRecordController maintenanceRecordController;

        //constructor for adding maintenance record
        public MaintenanceRecordFormPage(HomePage homePage, InventoryBoat inventoryBoat)
        {
            InitializeComponent();
            HomePage = homePage;
            inventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            maintenanceRecordController = new MaintenanceRecordController(new MaintenanceRecordDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            this.inventoryBoat = inventoryBoat;
            btnEditMaintenanceRecord.Hide();
            btnRemoveMaintenanceRecord.Hide();
        }

        //constructor for editing maintenance record
        public MaintenanceRecordFormPage(HomePage homePage, InventoryBoat inventoryBoat, MaintenanceRecord maintenanceRecord)
        {
            InitializeComponent();
            HomePage = homePage;
            inventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            maintenanceRecordController = new MaintenanceRecordController(new MaintenanceRecordDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            this.inventoryBoat = inventoryBoat;
            this.maintenanceRecord = maintenanceRecord;
            dtpStartDate.Value = maintenanceRecord.StartDate;
            dtpEndDate.Value = maintenanceRecord.EndDate;
            btnAddMaintenanceRecord.Hide();
        }

        //add maintenance record
        private void btnAddMaintenanceRecord_Click(object sender, EventArgs e)
        {
            if (ValidateMaintenanceRecordInput())
            {
                if (maintenanceRecordController.AddMaintenanceRecord(new MaintenanceRecord(inventoryBoat.InventoryID, dtpStartDate.Value, dtpEndDate.Value), inventoryBoat))
                {
                    MessageBox.Show("Successfully added maintenance");
                }
                else
                    MessageBox.Show("Fail to add");
            }
        }

        //edit maintenance record
        private void btnEditMaintenanceRecord_Click(object sender, EventArgs e)
        {
            if (ValidateMaintenanceRecordInput())
            {
                maintenanceRecord.StartDate = dtpStartDate.Value;
                maintenanceRecord.EndDate = dtpEndDate.Value;

                if (maintenanceRecordController.UpdateMaintenanceRecord(maintenanceRecord, inventoryBoat))
                {
                    MessageBox.Show("Updated");
                }
                else
                    MessageBox.Show("Fail to update");
            }
        }

        //remove maintenance record
        private void btnRemoveMaintenanceRecord_Click(object sender, EventArgs e)
        {
            if (maintenanceRecordController.RemoveMaintenanceRecord(maintenanceRecord, inventoryBoat))
            {
                MessageBox.Show("Removed");
                HomePage.ShowEditInventoryItemForm(inventoryBoat);
            }
            else
                MessageBox.Show("Fail to remove");
        }

        private bool ValidateMaintenanceRecordInput()
        {
            bool result = true;

            //if start date is bigger than end date
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("End date must be higher than start date");
                result = false;
            }
            return result;
        }
    }
}
