using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using VehicleParking.Service;

namespace VehicleParking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private readonly IParkingService _parkingService;
        public ParkingController(IParkingService parkingService)
        {
            _parkingService = parkingService;
        }

        /// <summary>
        /// To Park a Vehicle
        /// </summary>
        /// <param name="parkingLotNo"></param>
        /// <param name="parkingSpaceNo"></param>
        /// <param name="email"></param>
        /// <param name="vehicleNo"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Park")]
        public string ParkingVehicle(int parkingLotNo, int parkingSpaceNo, string email, string vehicleNo, string size)
        {
            _parkingService.AddParking(parkingLotNo, parkingSpaceNo, email, vehicleNo, size);
            return "Successfully parked";
        }

        [HttpPut]
        [Route("MoveVehicle")]
        public string UpdateParking(string vehicleNo, int parkingLotNo, int parkingSpaceNo)
        {
            _parkingService.UpdateParking(vehicleNo, parkingLotNo, parkingSpaceNo);
            return "Vehicle moved sucessfully";
        }

        [HttpGet]
        [Route("Vehicles")]
        public string Vehicles()
        {
            return "";
        }

        [HttpGet]
        [Route("VehicleNumber")]
        public string Vehicle(string vehicleNo)
        {
            return "";
        }


        [HttpPut]
        [Route("RemoveVehicle")]
        public string RemoveVehicle(string vehicleNo)
        {
            return "";
        }


    }
}
