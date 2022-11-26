using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public interface IUserController
    {
        public List<User> GetAllUser();
        public bool AddUser(User user);
        public bool UpdateUser(User user);
        public bool RemoveUser(User user);
    }
}
