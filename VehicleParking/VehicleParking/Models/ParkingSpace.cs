using System;

namespace VehicleParking.Models
{
    public class ParkingSpace
    {
        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Guid ParkingLotId { get; set; }
        public ParkingLot ParkingLot { get; set; }
    }
}
