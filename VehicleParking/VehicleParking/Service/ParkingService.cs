using System;
using VehicleParking.Repository;

namespace VehicleParking.Service
{
    public class ParkingService : IParkingService
    {
        private readonly IParkingRepository _parkingRepository;
        public ParkingService(IParkingRepository parkingRepository)
        {
            _parkingRepository = parkingRepository;
        }
        public string AddParking(int parkingLotNo, int parkingSpaceNo, string email, string vehicleNo, string size)
        {
            _parkingRepository.AddParking(parkingLotNo, parkingSpaceNo, email, vehicleNo, size);
            return "";
        }

        public string UpdateParking(string vehicleNo, int parkingLotNo, int parkingSpaceNo)
        {
            _parkingRepository.UpdateParking(vehicleNo, parkingLotNo, parkingSpaceNo);
            return "";
        }

        public string Parkings()
        {
            _parkingRepository.Parkings();
            return "";
        }

        public string RemoveVehicle(string vehicleNo)
        {
            _parkingRepository.RemoveVehicle(vehicleNo);
            return "";
        }
    }
}
