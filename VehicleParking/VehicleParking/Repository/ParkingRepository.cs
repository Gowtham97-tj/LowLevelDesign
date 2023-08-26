using System;
using System.Linq;
using VehicleParking.Models;

namespace VehicleParking.Repository
{
    public class ParkingRepository : IParkingRepository
    {
        private AppDbContext _context;
        public ParkingRepository()
        {
            _context = new AppDbContext();
        }
        public string AddParking(int parkingLotNo, int parkingSpaceNo, string email, string vehicleNo, string size)
        {
            var parkingSpace = _context.parkingSpaces.FirstOrDefault(u => u.ParkingSpaceNo == parkingSpaceNo);
            if (!parkingSpace.IsOccupied)
            {
                var user = _context.users.FirstOrDefault(e => e.Email == email);
                user.Vehicles.Add(new Vehicle(vehicleNo, size));
                var vehicle = user.Vehicles.FirstOrDefault(u => u.LicensePlate == vehicleNo);
                parkingSpace.Vehicle = vehicle;
                parkingSpace.IsOccupied = true;
                _context.SaveChanges();
            }
            return "";
        }

        public string UpdateParking(string vehicleNo, int parkingLotNo, int parkingSpaceNo)
        {
            return "";
        }

        public string Parkings()
        {
            return "";
        }

        public string RemoveVehicle(string vehicleNo)
        {
            return "";
        }
    }
}
