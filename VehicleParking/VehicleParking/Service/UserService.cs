using System.Collections.Generic;
using VehicleParking.Models;
using VehicleParking.Repository;

namespace VehicleParking.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public string AddUser(string email)
        {
            _userRepository.AddUser(email);
            return "";
        }

        public List<User> Users()
        {
            return _userRepository.Users();
        }

        public string DeleteUser(string email)
        {
            _userRepository.DeleteUser(email);
            return "";
        }
    }
}
