using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class CustomerController : IUserController
    {
        IStorageOption<Customer> customerDAL;

        public CustomerController(IStorageOption<Customer> customerDAL)
        {
            this.customerDAL = customerDAL;
        }

        public List<User> GetAllUser()
        {
            List<Customer> customers = customerDAL.GetAll();
            return customers.Cast<User>().ToList();
        }

        public bool AddUser(User user)
        {
            if (user is Customer)
            {
                //add to database
                return customerDAL.Add((Customer)user);
            }
            return false;
        }

        public bool UpdateUser(User user)
        {
            if (user is Customer)
            {
                //Update to database
                return customerDAL.Update((Customer)user);
            }
            return false;
        }

        public bool RemoveUser(User user)
        {
            if (user is Customer)
            {
                //remove from database
                return customerDAL.Remove((Customer)user);
            }
            return false;
        }

        
    }
}
