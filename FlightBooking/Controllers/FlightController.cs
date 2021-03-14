using AutoMapper;
using DAL;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public FlightController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [Route("GetList")]
        [HttpGet]
        public ActionResult GetAllFilghts()
        {
            var flightList = _unitOfWork.flightMasterRepository.GetAll( );
            return Ok(flightList);
        }

        [Route("CreateEntry")]
        [HttpGet]
        public ActionResult Addlight(FlightDetails flightData)
        {

            FlightDetails objFlightDetails = flightData;
           _unitOfWork.flightDetailsRepository.Add(objFlightDetails);
            return Ok();
        }
    }
}
