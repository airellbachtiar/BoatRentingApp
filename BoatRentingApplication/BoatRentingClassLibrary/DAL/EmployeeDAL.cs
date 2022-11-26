using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class EmployeeDAL : IStorageOption<Employee>
    {
        IStorageAccess _employeeDBAcess;
        public EmployeeDAL(IStorageAccess dBAccessEmployee)
        {
            _employeeDBAcess = dBAccessEmployee;
        }

        public List<Employee> GetAll()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                //Get table from database
                string sql = "SELECT * FROM employee";
                DataTable dataTable = _employeeDBAcess.GetData(sql);
                if (dataTable.Rows.Count != 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        //Assign data from table
                        int employeeID = Convert.ToInt32(row["EmployeeID"].ToString());
                        string name = row["Name"].ToString();
                        string username = row["Username"].ToString();
                        string email = row["Email"].ToString();
                        string phoneNumber = row["PhoneNumber"].ToString();
                        string password = row["Password"].ToString();

                        Employee employee = new Employee(email, name, username, password);
                        employee.ID = employeeID;

                        //Add to list
                        employees.Add(employee);
                    }
                }
                return employees;
            }
            catch(Exception)
            {
                return new List<Employee>();
            }
        }

        public bool Update(Employee employee)
        {
            try
            {
                //Update to database
                string sql = $"UPDATE `employee` SET `Name`='{employee.Name}',`Username`='{employee.Username}',`Email`='{employee.Email}',`PhoneNumber`='{employee.PhoneNumber}',`Password`='{employee.Password}' WHERE `EmployeeID` = {employee.ID}";
                _employeeDBAcess.PostData(sql);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool Add(Employee employee)
        {
            try
            {
                //Add to database
                string sql = $"INSERT INTO `employee` (`EmployeeID`, `Name`, `Username`, `Email`, `PhoneNumber`, `Password`) VALUES ('{employee.ID}', '{employee.Name}', '{employee.Username}', '{employee.Email}', '{employee.PhoneNumber}', '{employee.Password}')";
                _employeeDBAcess.PostData(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(Employee employee)
        {
            try
            {
                //remove from database
                string sql = $"DELETE FROM `employee` WHERE `EmployeeID` = {employee.ID}";
                _employeeDBAcess.PostData(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
