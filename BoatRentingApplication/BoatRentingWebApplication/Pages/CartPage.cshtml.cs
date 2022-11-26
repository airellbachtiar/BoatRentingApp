using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoatRentingClassLibrary;

namespace BoatRentingWebApplication.Pages
{
    public class CartPageModel : PageModel
    {
        public List<Cart> carts { get; set; }
        public ItemController ItemController = new ItemController(new ItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
        public InventoryItemController InventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));

        public List<InventoryItem> InventoryItems { get; set; }

        [BindProperty]
        public int ItemID { get; set; }

        [BindProperty]
        public int Amount { get; set; }

        public void OnGet()
        {
            carts = CartHelper.StringToCart(Request.Cookies["cart"]);
            InventoryItems = InventoryItemController.GetAllInventoryItem();
        }

        public IActionResult OnPost()
        {
            List<Cart> carts = CartHelper.StringToCart(Request.Cookies["cart"]);
            Item item = ItemController.GetItem(ItemID);
            Cart cart = new Cart(item, Amount);

            carts = CartHelper.ChangeCartAmount(carts, cart);
            Response.Cookies.Append("cart", CartHelper.CartToString(carts));
            OnGet();
            return Page();
        }
    }
}
