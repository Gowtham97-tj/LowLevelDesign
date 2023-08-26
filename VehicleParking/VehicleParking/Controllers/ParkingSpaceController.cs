using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using VehicleParking.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VehicleParking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingSpaceController : ControllerBase
    {
        private readonly IParkingSpaceService _parkingSpaceService;
        public ParkingSpaceController(IParkingSpaceService parkingSpaceService)
        {
            _parkingSpaceService = parkingSpaceService;
        }

        [HttpPost]
        [Route("AddParkingSpace")]
        public string AddParkingSpace(int parkingspaceNo, int lotNo)
        {
            _parkingSpaceService.AddParkingSpace(parkingspaceNo, lotNo);
            return "";
        }

        [HttpGet]
        [Route("ParkingSpaces")]
        public string ParkingSpaces()
        {
            return _parkingSpaceService.ParkingSpaces();
        }

        [HttpDelete]
        [Route("DeleteParkingSpace")]
        public string DeleteParkingSpace(int spaceNo)
        {
            return _parkingSpaceService.DeleteParkingSpace(spaceNo);
        }
    }
}
