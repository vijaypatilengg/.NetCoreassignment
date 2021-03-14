using DAL;
using DAL.Entities;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implimentation
{
   public class FlightDetailsRepository:Repository<FlightDetails>, IFlightDetailsRepository
    {
        public FlightDetailsRepository(DbContextConn dbocontextconn) : base(dbocontextconn)
        { 
        }
    }
}
