using DAL;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implimentation
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContextConn _dbContextConn;

        private IFlightDetailsRepository _flightDetailsRepository;
        private IFlightMasterRepository _flightMasterRepository;

        public UnitOfWork(DbContextConn dbContextConn)
        {
            _dbContextConn = dbContextConn;

        }

        public IFlightMasterRepository flightMasterRepository
        {

            get
            {
               return _flightMasterRepository = new FlightMasterRepository(_dbContextConn);
            }
        }

        public IFlightDetailsRepository flightDetailsRepository
        {

            get
            {
                return _flightDetailsRepository = new FlightDetailsRepository(_dbContextConn);
            }
        }
    }
}
