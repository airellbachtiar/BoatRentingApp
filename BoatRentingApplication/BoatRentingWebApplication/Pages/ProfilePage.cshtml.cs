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
    public class ProfilePageModel : PageModel
    {
        public User user { get; private set; }

        private UserController UserController = new UserController(new CustomerController(new CustomerDAL(new DBAccess(DatabaseHelper.mainDatabase))));

        [BindProperty]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter Email")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Phone Number is required")]
        [Phone(ErrorMessage = "Phone Number is required")]
        public string PhoneNumber { get; set; }

        [BindProperty]
        public string StreetName { get; set; }

        [BindProperty]
        public string ZipCode { get; set; }

        [BindProperty]
        public int HouseNumber { get; set; }

        [BindProperty]
        public string City { get; set; }



        public void OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                int userID = Convert.ToInt32(User.FindFirst("UserID").Value.ToString());
                user = UserController.GetUser(userID);
            }
        }

        public IActionResult OnPost()
        {
            if (User.Identity.IsAuthenticated && ModelState.IsValid)
            {
                int userID = Convert.ToInt32(User.FindFirst("UserID").Value.ToString());
                user = UserController.GetUser(userID);
                user.Name = Name;
                user.Username = Username;
                user.Email = Email;
                user.PhoneNumber = PhoneNumber;
                Address address = new Address(StreetName, ZipCode, HouseNumber, City);
                ((Customer)user).Address = address;
                UserController.UpdateUser(user);
            }
            return Page();
        }
    }
}
