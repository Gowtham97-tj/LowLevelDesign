using System;
using System.Collections.Generic;

namespace VehicleParking.Models
{
    public class User
    {
        public User(string email)
        {
            Email = email;
        }
        public Guid Id { get; set; }

        public string Email { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
