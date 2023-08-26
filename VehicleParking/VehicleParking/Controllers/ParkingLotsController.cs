using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VehicleParking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingLotsController : ControllerBase
    {
        private IConfiguration _configuration;
        public ParkingLotsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("AddParkingLot")]
        public string AddParkingLot(int parkingspaces)
        {
            return "";
        }

        [HttpPut]
        [Route("UpdateParkingLot")]
        public string UpdateParkingLot(Guid id, int parkingspaces)
        {
            return "";
        }

        [HttpGet]
        [Route("ParkingLots")]
        public string ParkingLots()
        {
            return "";
        }

        [HttpDelete]
        [Route("DeleteParkingLot")]
        public string DeleteParkingLot(Guid id)
        {
            return "";
        }
    }
}
