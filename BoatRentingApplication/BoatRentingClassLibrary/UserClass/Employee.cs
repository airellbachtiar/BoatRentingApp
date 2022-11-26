using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class Employee : User
    {
        public Employee(string email, string name, string username, string password) : base(email, name, username, password)
        {
        }
    }
}
