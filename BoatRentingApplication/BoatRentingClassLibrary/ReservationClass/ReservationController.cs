using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class ReservationController
    {
        private List<Reservation> reservations;
        private IStorageOption<Reservation> reservationDAL;

        public ReservationController(IStorageOption<Reservation> reservationDAL)
        {
            this.reservationDAL = reservationDAL;
        }

        public List<Reservation> GetAllReservation()
        {
            reservations = reservationDAL.GetAll();
            return reservations;
        }

        public bool AddReservation(Reservation reservation)
        {
            reservations = GetAllReservation();
            bool result = CheckAddReservation(reservation);

            //check availability of reservation
            if (reservations.Count != 0)
            {
                //get highest number and add 1
                int highestID = reservations.Max(reservation => reservation.ReferenceNumber);
                reservation.ReferenceNumber = ++highestID;
            }
            else
            {
                //assign 1 if it's the first entry
                reservation.ReferenceNumber = 1;
            }

            if (result)
            {
                return reservationDAL.Add(reservation);
            }
            return result;
        }

        public bool UpdateReservation(Reservation reservation)
        {
            bool result = CheckUpdateReservation(reservation);

            if (result)
            {
                return reservationDAL.Update(reservation);
            }
            return result;
        }

        public bool RemoveReservation(Reservation reservation)
        {
            return reservationDAL.Remove(reservation);
        }

        private bool CheckAddReservation(Reservation reservation)
        {
            bool result = true;

            //check if all items is available
            foreach (InventoryItem i in reservation.InventoryItems)
            {
                if (!i.IsAvailable)
                {
                    result = false;
                }
            }

            //check if date is valid
            if (DateTime.Now > reservation.DateDetail.StartDate)
            {
                result = false;
            }

            //duration have to be increment of 2
            if (reservation.DateDetail.Duration % 2 != 0 || reservation.DateDetail.Duration == 0)
            {
                result = false;
            }

            return result;
        }

        private bool CheckUpdateReservation(Reservation reservation)
        {
            bool result = true;

            //check if date is valid
            if (DateTime.Now > reservation.DateDetail.StartDate)
            {
                result = false;
            }

            //duration have to be increment of 2
            if (reservation.DateDetail.Duration % 2 != 0 || reservation.DateDetail.Duration == 0)
            {
                result = false;
            }

            return result;
        }
    }
}
