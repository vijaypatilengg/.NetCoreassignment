using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Abstraction
{
  public  interface IUnitOfWork
    {
        public IFlightMasterRepository flightMasterRepository { get; }
        public IFlightDetailsRepository flightDetailsRepository { get; }
    }
}
