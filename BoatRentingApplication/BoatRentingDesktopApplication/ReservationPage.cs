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
    public partial class ReservationPage : Form
    {
        HomePage HomePage;
        ReservationController ReservationController = new ReservationController(new ReservationDAL(new DBAccess(DatabaseHelper.mainDatabase)));

        public ReservationPage(HomePage homePage)
        {
            InitializeComponent();
            HomePage = homePage;
            UpdateDataGridView();
        }

        //update data grid view for reservation
        private void UpdateDataGridView()
        {
            dgvReservationList.ColumnCount = 13;
            dgvReservationList.Columns[0].Name = "Reference Number";
            dgvReservationList.Columns[1].Name = "User Name";
            dgvReservationList.Columns[2].Name = "Phone Number";
            dgvReservationList.Columns[3].Name = "Location";
            dgvReservationList.Columns[4].Name = "Status";
            dgvReservationList.Columns[5].Name = "Coupon Name";
            dgvReservationList.Columns[6].Name = "Discount";
            dgvReservationList.Columns[7].Name = "Start Date";
            dgvReservationList.Columns[8].Name = "Duration";
            dgvReservationList.Columns[9].Name = "Total Deposit";
            dgvReservationList.Columns[10].Name = "Total Price";
            dgvReservationList.Columns[11].Name = "Damage Price";
            dgvReservationList.Columns[12].Name = "Customer Payment";

            foreach (Reservation r in ReservationController.GetAllReservation())
            {
                string couponCode = "";
                if (r.Coupon != null)
                {
                    couponCode = r.Coupon.Code;
                }
                dgvReservationList.Rows.Add(r.ReferenceNumber, r.User.Name, r.PhoneNumber, r.Location, r.Status, couponCode, r.PriceDetail.Discount, r.DateDetail.StartDate, r.DateDetail.Duration, r.PriceDetail.TotalDeposit, r.PriceDetail.TotalPrice, r.PriceDetail.DamagePrice, r.PriceDetail.CustomerPay);
            }
        }

        //edit reservation, open new page based on selected index
        private void btnEditReservation_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dgvReservationList.CurrentRow.Cells[0].Value);
            Reservation reservation = ReservationController.GetAllReservation().Where(reservation => reservation.ReferenceNumber == selectedID).FirstOrDefault();

            if (reservation != null)
            {
                HomePage.ShowReservationFormPage(reservation);
            }
        }
    }
}
