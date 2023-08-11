using System;
using System.Collections.Generic;

namespace VehicleParking.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
