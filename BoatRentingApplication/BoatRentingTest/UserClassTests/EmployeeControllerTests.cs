using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoatRentingClassLibrary;

namespace BoatRentingTest.UserClassTests
{
    [TestClass]
    public class EmployeeControllerTests
    {
        Employee TestUser = new Employee("Email", "Name", "Username", PasswordSecurity.GenerateHash("Password"));
        UserController userController = new UserController(new EmployeeController(new EmployeeLocalStorage()));
        Employee employee = null;

        [TestMethod]
        public void A1_AddUser_ReturnAddedUser()
        {
            userController.AddUser(TestUser);
            employee = GetUser(TestUser.Username);
            Assert.AreEqual(TestUser.Username, employee.Username);
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
            employee = GetUser(TestUser.Username);
            employee.Name = "Name2";
            userController.UpdateUser(employee);
            employee = GetUser(TestUser.Username);
            Assert.AreEqual("Name2", employee.Name);
        }

        [TestMethod]
        public void C1_RemoveUser_ReturnTrue()
        {
            userController.AddUser(TestUser);
            employee = GetUser(TestUser.Username);
            Assert.IsTrue(userController.RemoveUser(employee));
        }

        private Employee GetUser(string username)
        {
            foreach (User u in userController.GetAllUser())
            {
                if (u.Username == username && u is Employee)
                {
                    return (Employee)u;
                }
            }
            return null;
        }
    }
}
