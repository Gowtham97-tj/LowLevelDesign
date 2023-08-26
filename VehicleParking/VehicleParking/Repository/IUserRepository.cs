using System.Collections.Generic;
using VehicleParking.Models;

namespace VehicleParking.Repository
{
    public interface IUserRepository
    {
        public string AddUser(string email);
        public List<User> Users();
        public string DeleteUser(string email);
    }
}
