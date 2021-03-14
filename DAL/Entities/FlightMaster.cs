using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class FlightMaster
    {
        [Key]
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
