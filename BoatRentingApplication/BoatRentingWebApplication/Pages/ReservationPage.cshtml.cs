using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoatRentingClassLibrary;

namespace BoatRentingWebApplication.Pages
{
    public class ReservationPageModel : PageModel
    {
        ReservationController ReservationController = new ReservationController(new ReservationDAL(new DBAccess(DatabaseHelper.mainDatabase)));

        private UserController UserController = new UserController(new CustomerController(new CustomerDAL(new DBAccess(DatabaseHelper.mainDatabase))));
        public User user { get; private set; }

        public List<Reservation> reservations { get; set; }

        public void OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                int userID = Convert.ToInt32(User.FindFirst("UserID").Value.ToString());
                user = UserController.GetUser(userID);
                reservations = ReservationController.GetAllReservation().Where(reservation => reservation.User.ID == user.ID && reservation.Status != ReservationStatus.CLOSE.ToString()).ToList();
            }
            else
                RedirectToPage("/LoginForm");
        }
    }
}
