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

namespace BoatRentingDesktopApplication
{
    public partial class LoginPage : Form
    {
        private HomePage homePage;
        string username, password;
        UserController userController;

        public LoginPage(HomePage HomePage)
        {
            InitializeComponent();
            homePage = HomePage;
            userController = new UserController(new EmployeeController(new EmployeeDAL(new DBAccess(DatabaseHelper.mainDatabase))));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            homePage.ShowRegisterPage();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check input validation
            if(ValidateLogin())
            {
                username = tbxUsername.Text;
                //password hashed before checking to database
                password = PasswordSecurity.GenerateHash(tbxPassword.Text);

                //check user login
                foreach(User u in userController.GetAllUser())
                {
                    if(u.Username == username && u.Password == password)
                    {
                        LoggedUser.User = u;
                        homePage.UserLoggedIn();
                        this.Close();
                    }
                }
            }
        }

        //validate input
        private bool ValidateLogin()
        {
            bool result = true;

            //if input is empty
            if(string.IsNullOrEmpty(tbxUsername.Text))
            {
                MessageBox.Show("Insert Username");
                result = false;
            }

            //if input is empty
            if(string.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("Insert Password");
                result = false;
            }

            return result;
        }
    }
}
