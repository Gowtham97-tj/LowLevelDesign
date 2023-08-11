using BuildingBlocks.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace VehicleParking.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<User> users { get; set; }

        public DbSet<ParkingSpace> parkingSpaces { get; set; }

        public DbSet<ParkingLot> parkingLots { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=VehicleParking;Trusted_Connection=True;");
        }
    }
}
