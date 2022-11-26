using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class EmployeeLocalStorage : IStorageOption<Employee>
    {
        public List<Employee> GetAll()
        {
            return TemporaryStorage.EmployeeList.Cast<Employee>().ToList();
        }

        public bool Add(Employee obj)
        {
            List<Employee> employees = GetAll();
            employees.Add(obj);
            TemporaryStorage.EmployeeList = employees;
            return true;
        }

        public bool Update(Employee obj)
        {
            List<Employee> employees = GetAll();

            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].ID == obj.ID)
                {
                    employees[i] = obj;
                    break;
                }
            }

            TemporaryStorage.EmployeeList = employees;
            return true;
        }

        public bool Remove(Employee obj)
        {
            List<Employee> employees = GetAll();
            employees.Remove(obj);
            TemporaryStorage.EmployeeList = employees;
            return true;
        }
    }
}
