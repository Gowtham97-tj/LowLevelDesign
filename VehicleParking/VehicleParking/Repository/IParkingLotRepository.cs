using System;

namespace VehicleParking.Repository
{
    public interface IParkingLotRepository
    {
        public string AddParkingLot(int parkingspaces);
        public string UpdateParkingLot(Guid id, int parkingspaces);
        public string ParkingLots();
        public string DeleteParkingLot(Guid id);
    }
}
