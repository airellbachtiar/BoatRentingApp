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
    public partial class CouponPage : Form
    {
        HomePage HomePage;
        CouponController couponController;
        public CouponPage(HomePage homePage)
        {
            InitializeComponent();
            HomePage = homePage;
            couponController = new CouponController(new CouponDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            UpdateCouponDataGridView();
        }

        private void btnAddCoupon_Click(object sender, EventArgs e)
        {
            //move to coupon form page
            HomePage.ShowCouponFormPage();
        }

        private void UpdateCouponDataGridView()
        {
            //show coupon data in data grid view
            dgvCouponList.DataSource = couponController.GetAllCoupon();
        }

        private void btnEditCoupon_Click(object sender, EventArgs e)
        {
            //Move to edit coupon form based on selected id
            int selectedID = Convert.ToInt32(dgvCouponList.CurrentRow.Cells[0].Value);
            Coupon selectedCoupon = couponController.GetCoupon(selectedID);
            if (selectedCoupon != null)
            {
                HomePage.ShowEditCouponForm(selectedCoupon);
            }
        }
    }
}
