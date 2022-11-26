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
    public partial class CouponFormPage : Form
    {
        HomePage HomePage;
        CouponController couponController;

        public CouponFormPage(HomePage homePage)
        {
            InitializeComponent();
            HomePage = homePage;
            couponController = new CouponController(new CouponDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            InitializeCouponComboBox();
            DisplayCouponTypeFromComboBox(cbxCouponType.SelectedItem.ToString());
        }

        private void btnAddCoupon_Click(object sender, EventArgs e)
        {
            //check input validation
            if (ValidateAddCoupon())
            {
                //put input to datatype
                string code = tbxCouponCode.Text;
                int discount = Convert.ToInt32(tbxDiscount.Text);
                Coupon coupon = new Coupon(code, discount);

                //check if coupon is added
                bool result = false;
                switch (cbxCouponType.SelectedItem)
                {
                    case "Time Coupon"://Time Coupon
                        result = couponController.AddCoupon(new TimeCoupon(coupon, dtpEndDate.Value));
                        break;
                    case "Limited Coupon"://Limited Coupon
                        result = couponController.AddCoupon(new LimitedCoupon(coupon, Convert.ToInt32(nudTotalUses.Value)));
                        break;
                    case "Exclusive Coupon"://Exclusive Coupon
                        result = couponController.AddCoupon(new ExclusiveCoupon(coupon, Convert.ToInt32(nudCustomerID.Value)));
                        break;
                }

                //user indicator
                if (result)
                {
                    MessageBox.Show("Successfully added coupon");
                }
                else
                    MessageBox.Show("Fail to add");
            }
        }

        private bool ValidateAddCoupon()
        {
            bool result = true;

            //check if input is empty
            if (string.IsNullOrEmpty(tbxCouponCode.Text))
            {
                MessageBox.Show("Insert Code");
                result = false;
            }

            //check if input is not int
            if (!int.TryParse(tbxDiscount.Text, out int i))
            {
                MessageBox.Show("Insert Discount");
                result = false;
            }

            //check if coupon type is not selected
            if (cbxCouponType.SelectedItem == null)
            {
                MessageBox.Show("Insert Coupon Type");
                result = false;
            }
            return result;
        }

        private void InitializeCouponComboBox()
        {
            //setup combo box for coupon types
            cbxCouponType.Items.Add("Time Coupon");
            cbxCouponType.Items.Add("Limited Coupon");
            cbxCouponType.Items.Add("Exclusive Coupon");
            cbxCouponType.SelectedIndex = 0;
        }

        private void DisplayCouponTypeFromComboBox(string selectedItem)
        {
            //Display input based on the chosen coupon type
            if (selectedItem == "Time Coupon")
            {
                grpbxExclusiveCoupon.Hide();
                grpbxLimitedCoupon.Hide();
                grpbxTimeCoupon.Show();
            }
            if (selectedItem == "Limited Coupon")
            {
                grpbxTimeCoupon.Hide();
                grpbxExclusiveCoupon.Hide();
                grpbxLimitedCoupon.Show();
            }
            if (selectedItem == "Exclusive Coupon")
            {
                grpbxTimeCoupon.Hide();
                grpbxLimitedCoupon.Hide();
                grpbxExclusiveCoupon.Show();
            }
        }

        private void cbxCouponType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if index changed, display input changed
            DisplayCouponTypeFromComboBox(cbxCouponType.SelectedItem.ToString());
        }
    }
}
