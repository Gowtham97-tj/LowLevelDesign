using System;

namespace VehicleParking.Repository
{
    public interface IParkingSpaceRepository
    {
        public string AddParkingSpace(int spaceNo, int lotNo);
        public string ParkingSpaces();
        public string DeleteParkingSpace(int spaceNo);
    }
}
