using System.Collections.Generic;
using VehicleParking.Models;

namespace VehicleParking.Service
{
    public interface IUserService
    {
        public string AddUser(string email);
        public List<User> Users();
        public string DeleteUser(string email);
    }
}
