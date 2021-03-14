using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBooking.MapperModel
{
    public class FlightMasterVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public string SourceLocation { get; set; }
        public string Destination { get; set; }
        public string Location { get; set; }
        public double FlightAmount { get; set; }
        public int AvailableTickets { get; set; }
    }
}
