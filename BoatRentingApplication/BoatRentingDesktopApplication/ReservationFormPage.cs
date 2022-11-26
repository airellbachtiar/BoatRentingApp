using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatRentingClassLibrary;

namespace BoatRentingDesktopApplication
{
    public partial class ReservationFormPage : Form
    {
        HomePage HomePage;
        Reservation editReservation;
        ReservationController ReservationController = new ReservationController(new ReservationDAL(new DBAccess(DatabaseHelper.mainDatabase)));
        CouponController CouponController = new CouponController(new CouponDAL(new DBAccess(DatabaseHelper.mainDatabase)));

        public ReservationFormPage(HomePage homePage, Reservation reservation)
        {
            HomePage = homePage;
            editReservation = reservation;
            InitializeComponent();
            InitializeDataFields();
        }

        private void InitializeDataFields()
        {
            //Show rented items
            dgvRentedItems.ColumnCount = 5;
            dgvRentedItems.Columns[0].Name = "ID";
            dgvRentedItems.Columns[1].Name = "Status";
            dgvRentedItems.Columns[2].Name = "Is Available";
            dgvRentedItems.Columns[3].Name = "Item Name";
            dgvRentedItems.Columns[4].Name = "Is Boat";

            foreach (InventoryItem inv in editReservation.InventoryItems)
            {
                dgvRentedItems.Rows.Add(inv.InventoryID, inv.Status, inv.IsAvailable, inv.Item.Name, inv.Item.IsBoat);
            }

            //Basic Info
            tbxUserID.Text = editReservation.User.ID.ToString();
            tbxReferenceNumber.Text = editReservation.ReferenceNumber.ToString();
            dtpDateCreated.Value = editReservation.DateDetail.DateCreated;
            dtpStartDate.Value = editReservation.DateDetail.StartDate;
            nudDuration.Value = editReservation.DateDetail.Duration;
            tbxLocation.Text = editReservation.Location;

            //Misc.
            nudTotalPrice.Value = Convert.ToDecimal(editReservation.PriceDetail.TotalPrice);
            nudTotalDeposit.Value = Convert.ToDecimal(editReservation.PriceDetail.TotalDeposit);
            nudDamagePrice.Value = Convert.ToDecimal(editReservation.PriceDetail.DamagePrice);
            nudActualPrice.Value = Convert.ToDecimal(editReservation.PriceDetail.ActualPrice);
            if (editReservation.Coupon != null)
            {
                tbxCoupon.Text = editReservation.Coupon.Code;
                tbxDiscount.Text = editReservation.Coupon.Discount.ToString();
            }

            //Status combo box
            foreach (ReservationStatus r in Enum.GetValues(typeof(ReservationStatus)))
            {
                cbxStatus.Items.Add(r.ToString());
            }
            cbxStatus.SelectedItem = editReservation.Status;

            //Contact
            tbxStreetName.Text = editReservation.Address.StreetName;
            tbxZipcode.Text = editReservation.Address.ZipCode;
            nudHouseNumber.Value = editReservation.Address.HouseNumber;
            tbxCity.Text = editReservation.Address.City;
            tbxPhoneNumber.Text = editReservation.PhoneNumber;
        }

        private void btnSaveReservation_Click(object sender, EventArgs e)
        {
            if (ValidateEditReservation())
            {
                //Basic Info
                editReservation.DateDetail.StartDate = dtpStartDate.Value;
                editReservation.DateDetail.Duration = Convert.ToInt32(nudDuration.Value);
                editReservation.Location = tbxLocation.Text;

                //Misc.
                editReservation.Status = cbxStatus.SelectedItem.ToString();
                editReservation.PriceDetail.DamagePrice = Convert.ToDouble(nudDamagePrice.Value);

                //Coupon
                Coupon coupon = CouponController.GetAllCoupon().Where(coupon => coupon.Code == tbxCoupon.Text).FirstOrDefault();
                editReservation.Coupon = coupon;

                //Contact
                editReservation.PhoneNumber = tbxPhoneNumber.Text;
                editReservation.Address.StreetName = tbxStreetName.Text;
                editReservation.Address.ZipCode = tbxZipcode.Text;
                editReservation.Address.HouseNumber = Convert.ToInt32(nudHouseNumber.Value);
                editReservation.Address.City = tbxCity.Text;

                if (ReservationController.UpdateReservation(editReservation))
                {
                    MessageBox.Show("Successfully edited item");
                    HomePage.ShowReservationFormPage(editReservation);
                }
                else
                {
                    MessageBox.Show("Failed to edit");
                    HomePage.ShowReservationFormPage(ReservationController.GetAllReservation().Where(res => res.ReferenceNumber == editReservation.ReferenceNumber).FirstOrDefault());
                }
            }
        }

        private void btnRemoveReservation_Click(object sender, EventArgs e)
        {
            if (ReservationController.RemoveReservation(editReservation))
            {
                MessageBox.Show("Successfully removed item");
                HomePage.ShowReservationPage();
            }
            else
            {
                MessageBox.Show("Failed to remove");
            }
        }

        private void btnCheckDiscount_Click(object sender, EventArgs e)
        {
            Coupon coupon = CouponController.GetAllCoupon().Where(coupon => coupon.Code == tbxCoupon.Text).FirstOrDefault();
            coupon = CouponController.AssignCoupon(editReservation.User, editReservation.Coupon, coupon);
            if (coupon != null)
            {
                tbxDiscount.Text = coupon.Discount.ToString() + "% Off";
            }
            else
            {
                tbxDiscount.Text = "0";
            }
        }

        private bool ValidateEditReservation()
        {
            bool result = true;

            //Basic Info check
            if (dtpStartDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Date has to be higher than today's date");
                result = false;
            }
            if (nudDuration.Value == 0 || nudDuration.Value % 2 != 0)
            {
                MessageBox.Show("Duration can't be 0 or has to be increment of 2");
                result = false;
            }
            if (string.IsNullOrEmpty(tbxLocation.Text))
            {
                MessageBox.Show("Location is empty");
                result = false;
            }

            //Contact
            if (string.IsNullOrEmpty(tbxStreetName.Text))
            {
                MessageBox.Show("Street name is empty");
                result = false;
            }
            if (string.IsNullOrEmpty(tbxZipcode.Text))
            {
                MessageBox.Show("Zipcode is empty");
                result = false;
            }
            if (string.IsNullOrEmpty(tbxCity.Text))
            {
                MessageBox.Show("City is empty");
                result = false;
            }
            if (string.IsNullOrEmpty(tbxPhoneNumber.Text) && Regex.Match(tbxPhoneNumber.Text, @"^(\+[0-9])$").Success)
            {
                MessageBox.Show("Insert phone number");
                result = false;
            }
            return result;
        }
    }
}
