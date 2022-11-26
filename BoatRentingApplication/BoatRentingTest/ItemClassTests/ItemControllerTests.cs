using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoatRentingClassLibrary;
using System.Collections.Generic;

namespace BoatRentingTest.ItemClassTests
{
    [TestClass]
    public class ItemControllerTests
    {
        Item NormalItem = new Item("NormalItem", 3d, 3d, "", false);
        Item BoatItem = new Item("BoatItem", 3d, 3d, "", true);
        ItemController itemController = new ItemController(new ItemLocalStorage());

        Item item = null;

        public ItemControllerTests()
        {
            TemporaryStorage.ItemList = new List<Item>();
        }

        [TestMethod]
        public void A1_AddNormalItem_ReturnAddedNormalItem()
        {
            itemController.AddItem(NormalItem);
            item = GetItem(NormalItem.Name);
            Assert.AreEqual(NormalItem.Name, item.Name);
        }

        [TestMethod]
        public void A2_AddBoatItem_ReturnAddedBoatItem()
        {
            itemController.AddItem(BoatItem);
            item = GetItem(BoatItem.Name);
            Assert.AreEqual(BoatItem.Name, item.Name);
        }

        [TestMethod]
        public void A3_AddSameNameItem_ReturnFalse()
        {
            itemController.AddItem(NormalItem);
            Assert.IsFalse(itemController.AddItem(NormalItem));
        }

        [TestMethod]
        public void B1_UpdateNormalItem_Descirption_ReturnNewDescription()
        {
            itemController.AddItem(NormalItem);

            item = GetItem(NormalItem.Name);
            item.Description = "NewNormalItem";
            itemController.UpdateItem(item);
            item = GetItem(NormalItem.Name);

            Assert.AreEqual("NewNormalItem", item.Description);
        }

        [TestMethod]
        public void C1_RemoveNormalItem_ReturnNull()
        {
            item = GetItem(NormalItem.Name);
            itemController.RemoveItem(item);
            Assert.IsNull(GetItem(NormalItem.Name));
        }

        [TestMethod]
        public void C2_RemoveBoatItem_ReturnNull()
        {
            itemController.AddItem(BoatItem);
            item = GetItem("BoatItem");
            itemController.RemoveItem(item);
            Assert.IsNull(GetItem(BoatItem.Name));
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
