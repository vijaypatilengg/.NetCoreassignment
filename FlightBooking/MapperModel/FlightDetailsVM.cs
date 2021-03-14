using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBooking.MapperModel
{
    public class FlightDetailsVM
    {
        public int ID { get; set; }

        public string PassengerName { get; set; }
        public int PassengerAge { get; set; }
        public string PassengerGender { get; set; }
        public DateTime DateofJourney { get; set; }
        public int FlightId { get; set; }
    }
}
