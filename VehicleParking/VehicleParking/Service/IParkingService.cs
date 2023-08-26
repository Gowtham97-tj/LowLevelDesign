using System;

namespace VehicleParking.Service
{
    public interface IParkingService
    {
        public string AddParking(int parkingLotNo, int parkingSpaceNo, string email, string vehicleNo, string size);
        public string UpdateParking(string vehicleNo, int parkingLotNo, int parkingSpaceNo);
        public string Parkings();
        public string RemoveVehicle(string vehicleNo);
    }
}
