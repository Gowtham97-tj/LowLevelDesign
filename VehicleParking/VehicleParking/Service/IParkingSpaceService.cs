using System;

namespace VehicleParking.Service
{
    public interface IParkingSpaceService
    {
        public string AddParkingSpace(int spaceNo, int lotId);
        public string ParkingSpaces();
        public string DeleteParkingSpace(int spaceNo);
    }
}
