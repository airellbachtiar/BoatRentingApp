using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatRentingClassLibrary;

namespace BoatRentingDesktopApplication
{
    public partial class ProfilePage : Form
    {
        private HomePage homePage;
        UserController userController;

        public ProfilePage(HomePage homePage)
        {
            InitializeComponent();
            InitializeFields();
            this.homePage = homePage;
            userController = new UserController(new EmployeeController(new EmployeeDAL(new DBAccess(DatabaseHelper.mainDatabase))));
        }

        //initialize profile field
        private void InitializeFields()
        {
            if(LoggedUser.User != null)
            {
                tbxName.Text = LoggedUser.User.Name;
                tbxUsername.Text = LoggedUser.User.Username;
                tbxEmail.Text = LoggedUser.User.Email;
                tbxPhoneNumber.Text = LoggedUser.User.PhoneNumber;
            }
        }

        //save changes
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateChangeInformation())
            {
                LoggedUser.User.Name = tbxName.Text;
                LoggedUser.User.Username = tbxUsername.Text;
                LoggedUser.User.Email = tbxEmail.Text;
                LoggedUser.User.PhoneNumber = tbxPhoneNumber.Text;

                //check if update is possible
                if (userController.UpdateUser(LoggedUser.User))
                {
                    MessageBox.Show("Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        //check for input validation
        private bool ValidateChangeInformation()
        {
            bool result = true;
            var emailCheck = new EmailAddressAttribute();
            if (string.IsNullOrEmpty(tbxName.Text))
            {
                MessageBox.Show("Insert Name");
                result = false;
            }
            if (string.IsNullOrEmpty(tbxUsername.Text))
            {
                MessageBox.Show("Insert username");
                result = false;
            }
            if (!emailCheck.IsValid(tbxEmail.Text))
            {
                MessageBox.Show("Insert email");
                result = false;
            }
            if (string.IsNullOrEmpty(tbxPhoneNumber.Text) && Regex.Match(tbxPhoneNumber.Text, @"^(\+[0-9])$").Success)
            {
                MessageBox.Show("Insert correct phone number");
                result = false;
            }
            return result;
        }


        //change password
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (ValidateChangePassword())
            {
                LoggedUser.User.Password = PasswordSecurity.GenerateHash(tbxConfirmPassword.Text);
                userController.UpdateUser(LoggedUser.User);
                MessageBox.Show("Password has been changed");
            }
            MessageBox.Show("Failed");
        }

        //validation for changing password
        private bool ValidateChangePassword()
        {
            bool result = true;
            if (string.IsNullOrEmpty(tbxOldPassword.Text))
            {
                MessageBox.Show("Insert password");
                result = false;
            }
            if (LoggedUser.User.Password != PasswordSecurity.GenerateHash(tbxOldPassword.Text))
            {
                MessageBox.Show("Incorrect password");
                result = false;
            }
            if (string.IsNullOrEmpty(tbxNewPassword.Text))
            {
                MessageBox.Show("Insert new password");
                result = false;
            }
            if (string.IsNullOrEmpty(tbxConfirmPassword.Text))
            {
                MessageBox.Show("Insert confirm password");
                result = false;
            }
            if (tbxNewPassword.Text != tbxConfirmPassword.Text)
            {
                MessageBox.Show("Password doesn't match");
                result = false;
            }
            return result;
        }
    }
}
