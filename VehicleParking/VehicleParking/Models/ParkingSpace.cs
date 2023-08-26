using System;

namespace VehicleParking.Models
{
    public class ParkingSpace
    {
        public Guid Id { get; set; }
        public int ParkingSpaceNo { get; set; }
        public Boolean IsOccupied { get; set; }
        public Guid VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Guid ParkingLotId { get; set; }
        public DateTime EntryTime { get; set; }
        public ParkingLot ParkingLot { get; set; }
    }
}
