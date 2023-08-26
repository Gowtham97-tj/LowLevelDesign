using System;

namespace VehicleParking.Models
{
    public class Vehicle
    {
        public Vehicle(string vehicleNo, string vehicleType)
        {
            this.VehicleType = vehicleType;
            LicensePlate = vehicleNo;
        }
        public Guid Id { get; set; }
        public string LicensePlate { get; set; }
        public string VehicleType { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
