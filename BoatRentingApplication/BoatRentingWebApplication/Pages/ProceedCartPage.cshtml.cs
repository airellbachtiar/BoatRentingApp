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
    public class ProceedCartPageModel : PageModel
    {
        public List<Cart> carts { get; set; }
        public ItemController ItemController = new ItemController(new ItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
        public InventoryItemController InventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
        public CouponController CouponController = new CouponController(new CouponDAL(new DBAccess(DatabaseHelper.mainDatabase)));
        public ReservationController ReservationController = new ReservationController(new ReservationDAL(new DBAccess(DatabaseHelper.mainDatabase)));
        
        private UserController UserController = new UserController(new CustomerController(new CustomerDAL(new DBAccess(DatabaseHelper.mainDatabase))));
        public User user { get; private set; }

        public Address Address { get; set; }

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
                carts = CartHelper.StringToCart(Request.Cookies["cart"]);
                int userID = Convert.ToInt32(User.FindFirst("UserID").Value.ToString());
                user = UserController.GetUser(userID);
                Address = ((Customer)user).Address;
            }
            else
                RedirectToPage("/LoginForm");
        }

        public IActionResult OnPostAddReservation()
        {
            if (ModelState.IsValid)
            {
                carts = CartHelper.StringToCart(Request.Cookies["cart"]);
                int userID = Convert.ToInt32(User.FindFirst("UserID").Value.ToString());
                user = UserController.GetUser(userID);

                List<InventoryItem> inventoryItems = new List<InventoryItem>();
                bool isSuccess = true;
                foreach (Cart c in carts)
                {
                    List<InventoryItem> temporaryList = InventoryItemController.GetInventoryItems(c.Item.ItemID, c.Amount);
                    if (temporaryList.Count == 0)
                    {
                        isSuccess = false;
                        carts.Remove(c);
                        break;
                    }
                    else
                    {
                        inventoryItems.AddRange(temporaryList);
                    }
                }

                if (!isSuccess)
                {
                    OnGet();
                    return Page();
                }
                else
                {
                    Reservation reservation = new Reservation(user, inventoryItems, StartDate, Duration);
                    reservation.Address = new Address(StreetName, Zipcode, HouseNumber, City);
                    reservation.Location = Location;
                    reservation.PhoneNumber = PhoneNumber;
                    if (!string.IsNullOrEmpty(CouponCode))
                    {
                        Coupon coupon = CouponController.GetAllCoupon().Where(coupon => coupon.Code == CouponCode).FirstOrDefault();
                        if (coupon != null)
                        {
                            reservation.Coupon = CouponController.AssignCoupon(user, null, coupon);
                        }
                    }

                    if (ReservationController.AddReservation(reservation))
                    {
                        Response.Cookies.Append("cart", "");
                        return Redirect("/Index");
                    }
                }
            }
            OnGet();
            return Page();
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
