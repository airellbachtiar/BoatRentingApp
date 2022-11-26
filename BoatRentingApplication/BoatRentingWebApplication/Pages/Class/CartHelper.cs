using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRentingClassLibrary;

namespace BoatRentingWebApplication.Pages
{
    public static class CartHelper
    {
        public static string CartToString(List<Cart> carts)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < carts.Count; i++)
            {
                sb.Append(carts[i].Item.ItemID);
                sb.Append('~');
                sb.Append(carts[i].Amount);

                //check if its the last member of the list, if not it adds a seperator
                if ((i + 1) < carts.Count)
                {
                    sb.Append('|');
                }
                //Format itemid~amount and | as seperator
            }
            return sb.ToString();
        }

        public static List<Cart> StringToCart(string cookies)
        {
            if (!string.IsNullOrWhiteSpace(cookies))
            {
                string[] seperatedCart = cookies.Split('|');
                ItemController itemController = new ItemController(new ItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));
                List<Cart> carts = new List<Cart>();

                foreach (string s in seperatedCart)
                {
                    //convert string to object
                    string[] cartDetail = s.Split('~');
                    Item item = itemController.GetItem(Convert.ToInt32(cartDetail[0]));
                    int amount = Convert.ToInt32(cartDetail[1]);
                    Cart cart = null;
                    if (item != null)
                    {
                        cart = new Cart(item, amount);
                        carts.Add(cart);
                    }
                }

                return carts;
            }
            return new List<Cart>();
        }

        public static List<Cart> AddToCart(List<Cart> carts, Cart cart)
        {
            bool itemIsThere = false;
            InventoryItemController inventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));

            foreach (Cart c in carts)
            {
                if (cart.Item.ItemID == c.Item.ItemID)
                {
                    itemIsThere = true;
                    int totalAmount = c.Amount + cart.Amount;
                    int availableItem = (inventoryItemController.GetAllInventoryItem().Where(inv => inv.Item.ItemID == cart.Item.ItemID && inv.IsAvailable)).Count();

                    //if its possible to add another amount, it will change the total amount of that item
                    if (availableItem >= totalAmount)
                    {
                        c.Amount = totalAmount;
                    }
                    //if amount already added exceed the availability of items it will give the maximum amount of item you can rent
                    else if (availableItem >= c.Amount)
                    {
                        c.Amount = availableItem;
                    }

                    //if user deletes all cart
                    if (c.Amount == 0)
                    {
                        carts.Remove(c);
                    }
                    break;
                }
            }

            if (!itemIsThere && cart.Amount != 0)
            {
                carts.Add(cart);
            }

            return carts;
        }

        public static List<Cart> ChangeCartAmount(List<Cart> carts, Cart cart)
        {
            bool itemIsThere = false;
            InventoryItemController inventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.mainDatabase)));

            foreach (Cart c in carts)
            {
                if (cart.Item.ItemID == c.Item.ItemID)
                {
                    itemIsThere = true;
                    int availableItem = (inventoryItemController.GetAllInventoryItem().Where(inv => inv.Item.ItemID == cart.Item.ItemID && inv.IsAvailable)).Count();

                    //if available item is bigger than inputed amount
                    if (availableItem >= cart.Amount)
                    {
                        c.Amount = cart.Amount;
                    }
                    //if amount already added exceed the availability of items it will give the maximum amount of item you can rent
                    else if (availableItem >= c.Amount)
                    {
                        c.Amount = availableItem;
                    }

                    //if user deletes all cart
                    if (c.Amount == 0)
                    {
                        carts.Remove(c);
                    }
                    break;
                }
            }

            if (!itemIsThere)
            {
                carts.Add(cart);
            }

            return carts;
        }
    }
}
