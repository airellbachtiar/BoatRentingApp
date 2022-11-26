using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoatRentingClassLibrary;

namespace BoatRentingTest.UserClassTests
{
    [TestClass]
    public class CustomerCOntrollerTests
    {
        Customer TestUser = new Customer("Email", "Name", "Username", PasswordSecurity.GenerateHash("Password"));
        UserController userController = new UserController(new CustomerController(new CustomerLocalStorage()));
        Customer customer = null;

        [TestMethod]
        public void A1_AddUser_ReturnAddedUser()
        {
            userController.AddUser(TestUser);
            customer = GetUser(TestUser.Username);
            Assert.AreEqual(TestUser.Username, customer.Username);
        }

        [TestMethod]
        public void A2_AddDuplicateUsername_ReturnFalse()
        {
            userController.AddUser(TestUser);
            Assert.IsFalse(userController.AddUser(TestUser));
        }

        [TestMethod]
        public void B1_UpdateUser_ReturnNewName()
        {
            userController.AddUser(TestUser);
            customer = GetUser(TestUser.Username);
            customer.Name = "Name2";
            userController.UpdateUser(customer);
            customer = GetUser(TestUser.Username);
            Assert.AreEqual("Name2", customer.Name);
        }

        [TestMethod]
        public void C1_RemoveUser_ReturnTrue()
        {
            userController.AddUser(TestUser);
            customer = GetUser(TestUser.Username);
            Assert.IsTrue(userController.RemoveUser(customer));
        }

        private Customer GetUser(string username)
        {
            foreach (User u in userController.GetAllUser())
            {
                if (u.Username == username && u is Customer)
                {
                    return (Customer)u;
                }
            }
            return null;
        }
    }
}

