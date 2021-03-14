using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
  public  class FlightDetails
    {
        [Key]
        public int ID { get; set; }
     
        public string PassengerName { get; set; }
        public int PassengerAge { get; set; }
        public string PassengerGender { get; set; }
        public DateTime DateofJourney { get; set; }
        public int FlightId { get; set; }
        
        public FlightMaster flightMaster { get; set; }
    }
}
