using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class ReservationLocalStorage : IStorageOption<Reservation>
    {
        public List<Reservation> GetAll()
        {
            return TemporaryStorage.ReservationList.Cast<Reservation>().ToList();
        }

        public bool Add(Reservation obj)
        {
            List<Reservation> reservations = GetAll();
            reservations.Add(obj);
            TemporaryStorage.ReservationList = reservations;
            return true;
        }

        public bool Update(Reservation obj)
        {
            List<Reservation> reservations = GetAll();

            //search and replace edited reservation
            for (int i = 0; i < reservations.Count; i++)
            {
                if (reservations[i].ReferenceNumber == obj.ReferenceNumber)
                {
                    reservations[i] = obj;
                    break;
                }
            }
            TemporaryStorage.ReservationList = reservations;
            return true;
        }

        public bool Remove(Reservation obj)
        {
            List<Reservation> reservations = GetAll();
            GetAll().Remove(obj);
            TemporaryStorage.ReservationList = reservations;
            return true;
        }
    }
}
