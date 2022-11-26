using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoatRentingClassLibrary;

namespace BoatRentingWebApplication.Pages
{
    public class SignUpFormModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Username Required")]
        public string Username { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Email Required")]
        [EmailAddress(ErrorMessage = "Insert email")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="Phone number is required")]
        [Phone(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare(nameof(Password), ErrorMessage = "Passwords don't match.")]
        public string ConfirmPassword { get; set; }

        public void OnGet()
        {
        }

        public IActionResult Onpost()
        {
            if (ModelState.IsValid)
            {
                UserController userController = new UserController(new CustomerController(new CustomerDAL(new DBAccess(DatabaseHelper.mainDatabase))));
                Customer customer = new Customer(Email, Name, Username, PasswordSecurity.GenerateHash(Password));
                customer.PhoneNumber = PhoneNumber;
                if (userController.AddUser(customer))
                {
                    return Redirect("/LoginForm");
                }
                return Page();
            }
            return Page();
        }
    }
}
