using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class ReservationDateDetail
    {
        public ReservationDateDetail(DateTime startDate, int duration)
        {
            DateCreated = DateTime.Now;
            StartDate = startDate;
            Duration = duration;
        }
        public DateTime DateCreated { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
    }
}
