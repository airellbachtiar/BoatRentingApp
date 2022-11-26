using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatRentingClassLibrary;

namespace BoatRentingDesktopApplication
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*UserController userController = new UserController(new EmployeeController());
            userController.AddUser(new Employee("a.a@a.a", "a", "a", PasswordSecurity.GenerateHash("a")));
            userController.AddUser(new Employee("a.a@a.a", "b", "b", PasswordSecurity.GenerateHash("b")));*/

            /*Item kayak = new Item("Kayak", 3d, 2d, "include peddle", true);
            Item container = new Item("Water Container", 3d, 2d, "2 L max", false);
            ItemController itemController = new ItemController(new ItemDAL(new DBAccess(DatabaseHelper.localHostConnection)));
            itemController.AddItem(kayak);
            itemController.AddItem(container);

            InventoryBoat kayakItem = new InventoryBoat(kayak, 2);
            InventoryItem containerItem = new InventoryItem(container);

            InventoryItemController inventoryItemController = new InventoryItemController(new InventoryItemDAL(new DBAccess(DatabaseHelper.localHostConnection)));
            inventoryItemController.AddInventoryItem(new InventoryBoat(kayak, 2));
            inventoryItemController.AddInventoryItem(new InventoryBoat(kayak, 2));
            inventoryItemController.AddInventoryItem(new InventoryItem(container));
            inventoryItemController.AddInventoryItem(new InventoryItem(container));
            inventoryItemController.AddInventoryItem(new InventoryBoat(kayak, 2));
            inventoryItemController.AddInventoryItem(new InventoryBoat(kayak, 2));
            inventoryItemController.AddInventoryItem(new InventoryItem(container));
            inventoryItemController.AddInventoryItem(new InventoryBoat(kayak, 2));*/

            /*CouponController couponController = new CouponController(new CouponDAL(new DBAccess(DatabaseHelper.localHostConnection)));
            couponController.AddCoupon(new Coupon("5%Discount", 5));
            couponController.AddCoupon(new Coupon("10%Discount", 10));
            couponController.AddCoupon(new ExclusiveCoupon( new Coupon("15%Discount", 15), 1));*/

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePage());
        }
    }
}
