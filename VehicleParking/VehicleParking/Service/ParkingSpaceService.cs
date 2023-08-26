using System;
using VehicleParking.Repository;

namespace VehicleParking.Service
{
    public class ParkingSpaceService : IParkingSpaceService
    {
        private IParkingSpaceRepository _parkingSpaceRepository;
        public ParkingSpaceService(IParkingSpaceRepository parkingSpaceRepository)
        {
            _parkingSpaceRepository = parkingSpaceRepository;
        }

        public string AddParkingSpace(int spaceNo, int lotId)
        {
            _parkingSpaceRepository.AddParkingSpace(spaceNo, lotId);
            return "";
        }

        public string ParkingSpaces()
        {
            _parkingSpaceRepository.ParkingSpaces();
            return "";
        }

        public string DeleteParkingSpace(int spaceNo)
        {
            _parkingSpaceRepository.DeleteParkingSpace(spaceNo);
            return "";
        }
    }
}
