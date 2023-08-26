using System;
using System.Linq;
using VehicleParking.Models;

namespace VehicleParking.Repository
{
    public class ParkingSpaceRepository : IParkingSpaceRepository
    {
        private AppDbContext _appContext;
        public ParkingSpaceRepository()
        {
            _appContext = new AppDbContext();
        }
        public string AddParkingSpace(int spaceNo, int lotNo)
        {
            return "";
        }

        public string ParkingSpaces()
        {
            _appContext.parkingSpaces.ToList();
            return "";
        }

        public string DeleteParkingSpace(int spaceNo)
        {
            return "";
        }
    }
}
