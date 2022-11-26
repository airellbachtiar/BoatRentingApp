using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public interface IStorageAccess
    {
        public DataTable GetData(string command);
        public void PostData(string command);
    }
}
