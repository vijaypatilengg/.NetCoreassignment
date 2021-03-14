using DAL;
using DAL.Entities;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implimentation
{
   public class FlightMasterRepository:Repository<FlightMaster>, IFlightMasterRepository
    {
        public FlightMasterRepository(DbContextConn dbcontextconn) : base(dbcontextconn)
        {
        }
    }
}
