using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class UserController
    {
        IUserController _userController;
        static List<User> users;

        public UserController(IUserController _userController)
        {
            this._userController = _userController;
            users = _userController.GetAllUser();
        }

        public List<User> GetAllUser()
        {
            //get user from chosen controller
            users = _userController.GetAllUser();
            return users;
        }

        public User GetUser(int id)
        {
            //refresh users
            users = GetAllUser();

            //search matching id
            foreach (User u in users)
            {
                if (u.ID == id)
                {
                    return u;
                }
            }
            return null;
        }

        public bool AddUser(User user)
        {
            //refresh users
            users = GetAllUser();

            //assign id
            if (users.Count != 0)
            {
                //assign highest id plus 1
                int highestID = users.Max(user => user.ID);
                user.ID = ++highestID;
            }
            else
            {
                //assign 1 if it's the first entry
                user.ID = 1;
            }

            bool result = CheckDuplicate(user);

            if (result)
            {
                //add user to the chosen controller
                return _userController.AddUser(user);
            }
            return result;
            
        }

        public bool UpdateUser(User user)
        {
            return _userController.UpdateUser(user);
        }

        public bool RemoveUser(User user)
        {
            //remove from database
            return _userController.RemoveUser(user);
        }

        //Login method, return user or if fails, return null
        public User Login(string username, string password)
        {
            string hashPassword = PasswordSecurity.GenerateHash(password);
            users = GetAllUser();
            foreach (User u in users)
            {
                if (u.Username == username && u.Password == hashPassword)
                {
                    return u;
                }
            }
            return null;
        }

        //check duplicate username
        private bool CheckDuplicate(User user)
        {
            foreach (User u in users)
            {
                if (u.Username == user.Username)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
