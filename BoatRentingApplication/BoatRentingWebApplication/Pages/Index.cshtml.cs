using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoatRentingClassLibrary;

namespace BoatRentingWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ItemController ItemController = new ItemController(new ItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
        public InventoryItemController InventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));

        [BindProperty]
        public int Amount { get; set; }

        [BindProperty]
        public int ItemID { get; set; }

        [BindProperty]
        public List<Item> Items { get; set; }

        [BindProperty]
        public List<InventoryItem> InventoryItems { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Items = ItemController.GetAllItem();
            InventoryItems = InventoryItemController.GetAllInventoryItem();
        }

        public void OnPost()
        {
            List<Cart> carts = CartHelper.StringToCart(Request.Cookies["cart"]);
            Item item = ItemController.GetItem(ItemID);
            Cart cart = new Cart(item, Amount);

            carts = CartHelper.AddToCart(carts, cart);
            Response.Cookies.Append("cart", CartHelper.CartToString(carts));
            OnGet();
        }
    }
}
