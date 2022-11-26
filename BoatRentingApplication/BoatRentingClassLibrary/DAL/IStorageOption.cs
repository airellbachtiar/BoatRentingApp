using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public interface IStorageOption<T>
    {
        public List<T> GetAll();
        public bool Update(T obj);
        public bool Add(T obj);
        public bool Remove(T obj);
    }
}
