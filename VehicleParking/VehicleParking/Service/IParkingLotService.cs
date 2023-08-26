using System;

namespace VehicleParking.Service
{
    public interface IParkingLotService
    {
        public string AddParkingLot(int parkingspaces);
        public string UpdateParkingLot(Guid id, int parkingspaces);
        public string ParkingLots();
        public string DeleteParkingLot(Guid id);
    }
}
