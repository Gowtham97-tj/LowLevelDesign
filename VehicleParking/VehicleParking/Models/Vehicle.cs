using System;

namespace VehicleParking.Models
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string LicensePlate { get; set; }
        public string VehicleType { get; set; }
        public DateTime EntryTime { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
