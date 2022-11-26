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
    public class ChangePasswordPageModel : PageModel
    {
        public User user { get; private set; }

        private UserController UserController = new UserController(new CustomerController(new CustomerDAL(new DBAccess(DatabaseHelper.mainDatabase))));

        [BindProperty]
        [Required(ErrorMessage = "Password is required")]
        public string OldPassword { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "New password is required")]
        public string NewPassword { get; set; }

        [BindProperty]
        [Compare(nameof(NewPassword), ErrorMessage = "New password doesn't match.")]
        public string ConfirmNewPassword { get; set; }


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
                if (PasswordSecurity.GenerateHash(OldPassword) == user.Password)
                {
                    user.Password = PasswordSecurity.GenerateHash(ConfirmNewPassword);
                    UserController.UpdateUser(user);
                }
            }
            return Page();
        }
    }
}
