using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DAL.Entities;

namespace DAL
{
   public class DbContextConn:DbContext
    {

        public DbContextConn(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { 
        
        }

        //protected override void Onconfigguring()
        public DbSet<FlightMaster> flightMasters { get; set; }
        public DbSet<FlightDetails> flightDetails { get; set; }
    }
}
