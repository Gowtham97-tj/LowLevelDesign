using System;
using System.Collections.Generic;

namespace VehicleParking.Models
{
    public class ParkingLot
    {
        public Guid Id { get; set; }
        public int LotNo { get; set; }
        public ICollection<ParkingSpace> ParkingSpaces { get; set; }
    }
}
