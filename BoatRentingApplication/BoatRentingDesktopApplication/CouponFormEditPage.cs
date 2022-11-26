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
    public partial class CouponFormEditPage : Form
    {
        HomePage HomePage;
        CouponController couponController;
        Coupon editCoupon;

        public CouponFormEditPage(HomePage homePage, Coupon coupon)
        {
            InitializeComponent();
            editCoupon = coupon;
            HomePage = homePage;
            couponController = new CouponController(new CouponDAL(new DBAccess(DatabaseHelper.mainDatabase)));
            InitializeCouponComboBox();
            InitializeEditForm(coupon);
            DisplayCouponTypeFromComboBox(cbxCouponType.SelectedItem.ToString());
        }

        private void btnEditCoupon_Click(object sender, EventArgs e)
        {
            //Check input
            if (ValidateEditCoupon())
            {
                //Convert input to data type
                string code = tbxCouponCode.Text;
                int discount = Convert.ToInt32(tbxDiscount.Text);
                editCoupon.Code = code;
                editCoupon.Discount = discount;

                //Assign coupon based on type
                if (editCoupon is ExclusiveCoupon)
                {
                    ((ExclusiveCoupon)editCoupon).CustomerID = Convert.ToInt32(nudCustomerID.Value);
                }
                else if(editCoupon is LimitedCoupon)
                {
                    int totalUses = Convert.ToInt32(nudTotalUses.Value);
                    int remainingUses = Convert.ToInt32(nudRemainingUses.Value);
                    if (totalUses >= remainingUses)
                    {
                        ((LimitedCoupon)editCoupon).TotalUses = totalUses;
                        ((LimitedCoupon)editCoupon).RemainingUses = remainingUses;
                    }
                }
                else if(editCoupon is TimeCoupon)
                {
                    ((TimeCoupon)editCoupon).EndDate = dtpEndDate.Value;
                }

                //User Indicator
                if (couponController.UpdateCoupon(editCoupon))
                {
                    MessageBox.Show("Coupon updated");
                }
                else
                {
                    MessageBox.Show("Failed to update");
                }
            }
        }

        private void btnRemoveCoupon_Click(object sender, EventArgs e)
        {
            //Remove coupon
            if (couponController.RemoveCoupon(editCoupon))
            {
                MessageBox.Show("Coupon removed");
                HomePage.ShowCouponPage();
            }
            else
            {
                MessageBox.Show("Failed to remove");
            }
        }

        private bool ValidateEditCoupon()
        {
            bool result = true;

            //check is input is empty
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

            //check if coupon is not picked
            if (cbxCouponType.SelectedItem == null)
            {
                MessageBox.Show("Insert Coupon Type");
                result = false;
            }

            return result;
        }

        private void InitializeCouponComboBox()
        {
            //Set up combo box for coupon type
            cbxCouponType.Items.Add("Time Coupon");
            cbxCouponType.Items.Add("Limited Coupon");
            cbxCouponType.Items.Add("Exclusive Coupon");
            cbxCouponType.SelectedIndex = 0;
        }

        private void InitializeEditForm(Coupon coupon)
        {
            //Setup edit form
            tbxCouponCode.Text = coupon.Code;
            tbxDiscount.Text = coupon.Discount.ToString();
            if (coupon is TimeCoupon)
            {
                cbxCouponType.SelectedItem = "Time Coupon";
                dtpEndDate.Value = ((TimeCoupon)coupon).EndDate;
            }
            if (coupon is LimitedCoupon)
            {
                cbxCouponType.SelectedItem = "Limited Coupon";
                nudTotalUses.Value = ((LimitedCoupon)coupon).TotalUses;
                nudRemainingUses.Value = ((LimitedCoupon)coupon).RemainingUses;
            }
            if (coupon is ExclusiveCoupon)
            {
                cbxCouponType.SelectedItem = "Exclusive Coupon";
                nudTotalUses.Value = ((ExclusiveCoupon)coupon).CustomerID;
            }
            cbxCouponType.Enabled = false;
        }

        private void DisplayCouponTypeFromComboBox(string selectedItem)
        {
            //display input based on chosen type
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
    }
}
