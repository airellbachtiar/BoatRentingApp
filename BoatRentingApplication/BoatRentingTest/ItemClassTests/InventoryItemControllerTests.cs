using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoatRentingClassLibrary;
using System.Linq;

namespace BoatRentingTest.ItemClassTests
{
    [TestClass]
    public class InventoryItemControllerTests
    {
        Item NormalItem = new Item("NormalItemForInventory", 3d, 3d, "", false);
        InventoryItemController inventoryItemController = new InventoryItemController(new InventoryItemLocalStorage());
        ItemController itemController = new ItemController(new ItemLocalStorage());

        [TestMethod]
        public void A1_AddInventoryItem_ReturnAddedInventoryItem()
        {
            itemController.AddItem(NormalItem);
            InventoryItem inventoryItem = new InventoryItem(NormalItem);
            inventoryItemController.AddInventoryItem(inventoryItem);
            InventoryItem addedInventoryItem = inventoryItemController.GetAllInventoryItem().Last();

            Assert.AreEqual(NormalItem, inventoryItem.Item);
        }

        [TestMethod]
        public void A2_UpdateInventoryItem_ReturnNewStatus()
        {
            itemController.AddItem(NormalItem);
            InventoryItem inventoryItem = new InventoryItem(NormalItem);
            inventoryItemController.AddInventoryItem(inventoryItem);

            inventoryItem = inventoryItemController.GetAllInventoryItem().Last();
            inventoryItem.Status = "Rented";
            inventoryItemController.UpdateInventoryItem(inventoryItem);

            InventoryItem newInventoryItem = inventoryItemController.GetAllInventoryItem().Last();
            Assert.AreEqual(inventoryItem.Status, newInventoryItem.Status);
        }

        [TestMethod]
        public void A3_RemoveInventoryItem_ReturnNull()
        {
            itemController.AddItem(NormalItem);
            InventoryItem inventoryItem = new InventoryItem(NormalItem);
            inventoryItemController.AddInventoryItem(inventoryItem);

            inventoryItem = inventoryItemController.GetAllInventoryItem().Last();
            Item item = GetItem(NormalItem.Name);
            itemController.RemoveItem(item);

            Assert.IsTrue(inventoryItemController.RemoveInventoryItem(inventoryItem));
        }

        private Item GetItem(string name)
        {
            foreach (Item i in itemController.GetAllItem())
            {
                if (i.Name == name)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
