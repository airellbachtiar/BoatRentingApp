using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class CustomerDAL : IStorageOption<Customer>
    {
        IStorageAccess _customerDBAcess;
        public CustomerDAL(IStorageAccess dBAccessCustomer)
        {
            _customerDBAcess = dBAccessCustomer;
        }

        public List<Customer> GetAll()
        {
            try
            {
                List<Customer> customers = new List<Customer>();
                //Get table from database
                string sql = "SELECT * FROM customer";
                DataTable dataTable = _customerDBAcess.GetData(sql);
                if (dataTable.Rows.Count != 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        //Assign data from table
                        int customerID = Convert.ToInt32(row["CustomerID"].ToString());
                        string name = row["Name"].ToString();
                        string username = row["Username"].ToString();
                        string email = row["Email"].ToString();
                        string phoneNumber = row["PhoneNumber"].ToString();
                        string password = row["Password"].ToString();

                        Customer customer = new Customer(email, name, username, password);
                        customer.ID = customerID;
                        customer.PhoneNumber = phoneNumber;

                        string streetName = row["Street"].ToString();
                        string zipCode = row["ZipCode"].ToString();
                        int houseNumber = Convert.ToInt32(row["HouseNumber"].ToString());
                        string city = row["City"].ToString();
                        customer.Address = new Address(streetName, zipCode, houseNumber, city);

                        //Add to list
                        customers.Add(customer);
                    }
                }
                return customers;
            }
            catch (Exception)
            {
                return new List<Customer>();
            }
        }

        public bool Update(Customer customer)
        {
            try
            {
                //Update to database
                string sql = $"UPDATE `customer` SET `Name`='{customer.Name}',`Username`='{customer.Username}',`Email`='{customer.Email}',`PhoneNumber`='{customer.PhoneNumber}',`Password`='{customer.Password}',`Street`='{customer.Address.StreetName}',`ZipCode`='{customer.Address.ZipCode}',`HouseNumber`='{customer.Address.HouseNumber}',`City`='{customer.Address.City}' WHERE `CustomerID`='{customer.ID}'";
                _customerDBAcess.PostData(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add(Customer customer)
        {
            try
            {
                //Add to database
                string sql = $"INSERT INTO `customer`(`CustomerID`, `Name`, `Username`, `Email`, `PhoneNumber`, `Password`, `Street`, `ZipCode`, `HouseNumber`, `City`) VALUES ('{customer.ID}','{customer.Name}','{customer.Username}','{customer.Email}','{customer.PhoneNumber}','{customer.Password}','{customer.Address.StreetName}','{customer.Address.ZipCode}','{customer.Address.HouseNumber}','{customer.Address.City}')";
                _customerDBAcess.PostData(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(Customer customer)
        {
            try
            {
                //Remove from database
                string sql = $"DELETE FROM `customer` WHERE `CustomerID`='{customer.ID}'";
                _customerDBAcess.PostData(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
