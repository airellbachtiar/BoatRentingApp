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
    public partial class HomePage : Form
    {
        Form OpenForm;

        public delegate Form ChangeForm();
        public ChangeForm changeForm;

        public HomePage()
        {
            InitializeComponent();
            UserLoggedOut();
        }

        //method for displaying input if user logged in
        public void UserLoggedIn()
        {
            btnLogout.Show();
            btnProfile.Show();
            btnLogin.Hide();

            btnCouponPage.Show();
            btnReservationPage.Show();
            btnItemPage.Show();
        }

        //method for displaying input if user logged out
        public void UserLoggedOut()
        {
            btnLogout.Hide();
            btnProfile.Hide();
            btnLogin.Show();

            btnCouponPage.Hide();
            btnReservationPage.Hide();
            btnItemPage.Hide();
        }

        //Clear opened page beside this home page
        private void ClearAllPages()
        {
            if(OpenForm != null)
            {
                OpenForm.Close();
                OpenForm = null;
            }
        }

        //open any inserted page
        private void OpenPage(Form newPage)
        {
            ClearAllPages();
            OpenForm = newPage;
            OpenForm.Dock = DockStyle.Fill;
            OpenForm.TopLevel = false;
            OpenForm.TopMost = true;
            OpenForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlPage.Controls.Add(OpenForm);
            OpenForm.Show();
        }

        //User Page
        #region
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ShowLoginPage();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserLoggedOut();
            ClearAllPages();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ShowProfilePage();
        }

        public void ShowLoginPage()
        {
            OpenPage(new LoginPage(this));
        }

        public void ShowRegisterPage()
        {
            OpenPage(new RegisterPage(this));
        }

        public void ShowProfilePage()
        {
            OpenPage(new ProfilePage(this));
        }
        #endregion

        //Coupon Page
        #region
        private void btnCouponPage_Click(object sender, EventArgs e)
        {
            ShowCouponPage();
        }

        public void ShowCouponPage()
        {
            OpenPage(new CouponPage(this));
        }

        public void ShowCouponFormPage()
        {
            OpenPage(new CouponFormPage(this));
        }

        public void ShowEditCouponForm(Coupon coupon)
        {
            OpenPage(new CouponFormEditPage(this, coupon));
        }

        public void ShowItemFormPage()
        {
            OpenPage(new ItemFormPage(this));
        }
        #endregion

        //Item, Inventory Item and Maintenance Record Page
        #region
        private void btnItemPage_Click(object sender, EventArgs e)
        {
            ShowItemPage();
        }

        public void ShowItemPage()
        {
            OpenPage(new ItemPage(this));
        }

        public void ShowEditItemForm(Item item)
        {
            OpenPage(new ItemFormEditItemPage(this, item));
        }

        public void ShowEditInventoryItemForm(InventoryItem inventoryItem)
        {
            OpenPage(new ItemFormEditInventoryItemPage(this, inventoryItem));
        }

        public void ShowAddMaintenanceRecord(InventoryBoat inventoryBoat)
        {
            OpenPage(new MaintenanceRecordFormPage(this, inventoryBoat));
        }

        public void ShowEditMaintenanceRecord(InventoryBoat inventoryBoat, MaintenanceRecord maintenanceRecord)
        {
            OpenPage(new MaintenanceRecordFormPage(this, inventoryBoat, maintenanceRecord));
        }

        #endregion

        //Reservation page
        #region
        private void btnReservationPage_Click(object sender, EventArgs e)
        {
            ShowReservationPage();
        }

        public void ShowReservationPage()
        {
            OpenPage(new ReservationPage(this));
        }

        public void ShowReservationFormPage(Reservation reservation)
        {
            OpenPage(new ReservationFormPage(this, reservation));
        }
        #endregion
    }
}
