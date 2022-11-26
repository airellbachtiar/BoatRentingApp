using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class Customer : User
    {
        public Customer(string email, string name, string username, string password) : base(email, name, username, password)
        {
            Email = email;
            Name = name;
            Username = username;
            Password = password;
            Address = new Address("", "", 0, "");
        }

        private Address address;

        public Address Address { get { return address; } set { address = value; } }
    }
}
