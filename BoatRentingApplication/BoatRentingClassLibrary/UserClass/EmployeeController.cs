using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class EmployeeController : IUserController
    {
        IStorageOption<Employee> employeeDAL;

        public EmployeeController(IStorageOption<Employee> employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }

        public List<User> GetAllUser()
        {
            List<Employee> employees = employeeDAL.GetAll();
            List<User> users = employees.Cast<User>().ToList();
            return users;
        }

        public bool AddUser(User user)
        {
            if (user is Employee)
            {
                //add to database
                return employeeDAL.Add((Employee)user);
            }
            return false;
        }

        public bool UpdateUser(User user)
        {
            if (user is Employee)
            {
                //update to database
                return employeeDAL.Update((Employee)user);
            }
            return false;
        }

        public bool RemoveUser(User user)
        {
            if (user is Employee)
            {
                //remove from database
                return employeeDAL.Remove((Employee)user);
            }
            return false;
        }

        
    }
}
