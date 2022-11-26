using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoatRentingClassLibrary;
using System.ComponentModel.DataAnnotations;

namespace BoatRentingWebApplication.Pages
{
    public class EditReservationPageModel : PageModel
    {
        public Reservation Reservation { get; set; }
        public ReservationController ReservationController = new ReservationController(new ReservationDAL(new DBAccess(DatabaseHelper.mainDatabase)));

        private UserController UserController = new UserController(new CustomerController(new CustomerDAL(new DBAccess(DatabaseHelper.mainDatabase))));
        private CouponController CouponController = new CouponController(new CouponDAL(new DBAccess(DatabaseHelper.mainDatabase)));

        public User user { get; set; }

        [BindProperty(SupportsGet = true)]
        public int ReferenceNumber { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Street name is required")]
        public string StreetName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Zipcode is required")]
        public string Zipcode { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "House number is required")]
        public int HouseNumber { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "StartDate is required")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Duration is required")]
        public int Duration { get; set; }

        [BindProperty]
        public string CouponCode { get; set; }

        [BindProperty]
        [RegularExpression(@"^true", ErrorMessage = "The checkbox is required")]
        public string IsChecked { get; set; }

        public void OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                int userID = Convert.ToInt32(User.FindFirst("UserID").Value.ToString());
                user = UserController.GetUser(userID);

                Reservation = ReservationController.GetAllReservation().Where(reservation => reservation.ReferenceNumber == ReferenceNumber).FirstOrDefault();
                if (Reservation == null)
                {
                    Redirect("/Index");
                }
            }
            else
                Redirect("/Index");
        }

        public IActionResult OnPostSaveReservation()
        {
            Reservation = ReservationController.GetAllReservation().Where(reservation => reservation.ReferenceNumber == ReferenceNumber).FirstOrDefault();
            if (ModelState.IsValid && Reservation != null)
            {
                int userID = Convert.ToInt32(User.FindFirst("UserID").Value.ToString());
                user = UserController.GetUser(userID);

                Reservation.Address = new Address(StreetName, Zipcode, HouseNumber, City);
                Reservation.Location = Location;
                Reservation.PhoneNumber = PhoneNumber;
                Reservation.DateDetail.StartDate = StartDate;
                Reservation.DateDetail.Duration = Duration;

                if (!string.IsNullOrEmpty(CouponCode))
                {
                    Coupon coupon = CouponController.GetAllCoupon().Where(coupon => coupon.Code == CouponCode).FirstOrDefault();
                    if (coupon != null)
                    {
                        Reservation.Coupon = CouponController.AssignCoupon(user, Reservation.Coupon, coupon);
                    }
                }
                else
                {
                    Reservation.Coupon = CouponController.AssignCoupon(user, Reservation.Coupon, null);
                }

                ReservationController.UpdateReservation(Reservation);
            }
            OnGet();
            return Page();
        }

        public IActionResult OnGetCancelReservation()
        {
            Reservation = ReservationController.GetAllReservation().Where(reservation => reservation.ReferenceNumber == ReferenceNumber).FirstOrDefault();
            ReservationController.RemoveReservation(Reservation);
            return Redirect("/Index");
        }

        public IActionResult OnPostCheckCoupon()
        {
            if (!string.IsNullOrEmpty(CouponCode))
            {
                Coupon coupon = CouponController.GetAllCoupon().Where(coupon => coupon.Code == CouponCode).FirstOrDefault();
                if (coupon != null)
                {
                    ViewData["CouponCode"] = coupon.Discount.ToString() + "% Off";
                }
                else
                    ViewData["CouponCode"] = "Not found";
            }
            OnGet();
            return Page();
        }
    }
}
