using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoatRentingClassLibrary;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace BoatRentingWebApplication.Pages
{
    public class LoginFormModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Username is missing")]
        public string Username { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password is missing")]
        public string Password { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                UserController userController = new UserController(new CustomerController(new CustomerDAL(new DBAccess(DatabaseHelper.mainDatabase))));
                User user = userController.Login(Username, Password);
                if (user != null)
                {
                    var claims = new List<Claim>()
                    {
                        new Claim("UserID", user.ID.ToString())
                    };
                    var identity = new ClaimsIdentity(claims, "MyCookiesAuth");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                    List<Cart> carts = new List<Cart>();
                    Response.Cookies.Append("cart", CartHelper.CartToString(carts));

                    await HttpContext.SignInAsync("MyCookiesAuth", claimsPrincipal);
                    return Redirect("/index");
                }
                else
                {
                    return Page();
                }
            }
            return Page();
        }
    }
}
