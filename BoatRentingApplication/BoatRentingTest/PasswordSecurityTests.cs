using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoatRentingClassLibrary;

namespace BoatRentingTest
{
    [TestClass]
    public class PasswordSecurityTests
    {
        [TestMethod]
        public void GenerateHash_StringPassword_ReturnHash()
        {
            Assert.IsNotNull(PasswordSecurity.GenerateHash("password"));
        }
    }
}
