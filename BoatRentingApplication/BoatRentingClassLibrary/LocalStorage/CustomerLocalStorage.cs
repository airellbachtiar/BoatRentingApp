using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class CustomerLocalStorage : IStorageOption<Customer>
    {
        public List<Customer> GetAll()
        {
            return TemporaryStorage.CustomerList.Cast<Customer>().ToList();
        }

        public bool Add(Customer obj)
        {
            List<Customer> customers = GetAll();
            customers.Add(obj);
            TemporaryStorage.CustomerList = customers;
            return true;
        }

        public bool Update(Customer obj)
        {
            List<Customer> customers = GetAll();

            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].ID == obj.ID)
                {
                    customers[i] = obj;
                    break;
                }
            }

            TemporaryStorage.CustomerList = customers;
            return true;
        }

        public bool Remove(Customer obj)
        {
            List<Customer> customers = GetAll();
            customers.Remove(obj);
            TemporaryStorage.CustomerList = customers;
            return true;
        }
    }
}
