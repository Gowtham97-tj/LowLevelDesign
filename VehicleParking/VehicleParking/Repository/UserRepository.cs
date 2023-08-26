using System.Collections.Generic;
using System.Linq;
using VehicleParking.Models;

namespace VehicleParking.Repository
{
    public class UserRepository : IUserRepository
    {
        private AppDbContext _context;

        public UserRepository()
        {
           _context  = new AppDbContext();
        }
        public string AddUser(string email)
        {
            using (var context = new AppDbContext())
            {
                var newUser = new User(email);
                context.users.Add(newUser);
                context.SaveChanges();
            }
            return "User Added";
        }

        public List<User> Users()
        {
            List<User> value = null;
            using (var context = new AppDbContext())
            {
                value = context.users.ToList();
            }
            return value;
        }

        public string DeleteUser(string email)
        {
            var user = _context.users.FirstOrDefault(e => e.Email == email);
            _context.users.Remove(user);
            _context.SaveChanges();
            return "";
        }
    }
}
