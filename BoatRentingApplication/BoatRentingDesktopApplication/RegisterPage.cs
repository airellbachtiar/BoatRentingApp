using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatRentingClassLibrary;
using System.ComponentModel.DataAnnotations;

namespace BoatRentingDesktopApplication
{
    public partial class RegisterPage : Form
    {
        private HomePage homePage;

        string name, email, username, password;

        public RegisterPage(HomePage HomePage)
        {
            InitializeComponent();
            homePage = HomePage;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            homePage.ShowLoginPage();
        }

        //register new user
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(ValidationCheck())
            {
                name = tbxName.Text;
                email = tbxEmail.Text;
                username = tbxUsername.Text;
                password = PasswordSecurity.GenerateHash(tbxPassword.Text);

                UserController userController = new UserController(new EmployeeController(new EmployeeDAL(new DBAccess(DatabaseHelper.mainDatabase))));
                if(userController.AddUser(new Employee(email, name, username, password)))
                {
                    ResetFields();
                    MessageBox.Show("Successfully added employee");
                }
                else
                {
                    MessageBox.Show("Failed to add");
                }
            }
        }

        //check input validation for registering
        private bool ValidationCheck()
        {
            bool result = true;
            var emailCheck = new EmailAddressAttribute();
            if((string.IsNullOrEmpty(tbxName.Text)))
            {
                MessageBox.Show("Insert Name");
                result = false;
            }
            if (!emailCheck.IsValid(tbxEmail.Text))
            {
                MessageBox.Show("Enter correct Email");
                result = false;
            }
            if (string.IsNullOrEmpty(tbxUsername.Text))
            {
                MessageBox.Show("Insert Username");
                result = false;
            }
            if (string.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("Insert Password");
                result = false;
            }
            if (tbxPassword.Text != tbxConfirmPassword.Text)
            {
                MessageBox.Show("Password doesn't match");
                result = false;
            }
            return result;
        }

        //if success, field will be reset
        private void ResetFields()
        {
            tbxName.Text = "";
            tbxUsername.Text = "";
            tbxEmail.Text = "";
            tbxPassword.Text = "";
            tbxConfirmPassword.Text = "";
        }
    }
}
