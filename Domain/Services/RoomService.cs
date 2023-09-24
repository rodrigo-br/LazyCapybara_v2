namespace Domain.Services
{
    using Common.Interfaces;
    using Domain.Models;

    public class RoomService
    {
        private readonly IValidation _validation;

        public RoomService(IValidation validation)
        {
            _validation = validation;
        }

        public Room CreateRoom(int id, decimal price, bool hasEnergyMeter)
        {
            return new Room(_validation)
            {
                Id = id,
                Price = price,
                HasEnergyMeter = hasEnergyMeter,
                EnergyMetering = new Stack<decimal>(),
                LastCheckOut = DateOnly.FromDateTime(DateTime.Now),
                TenantsHistory = new Stack<Tenant>(),
                CurrentTenants = new Stack<Tenant>()
            };
        }

        public void UpdateRoom(Room room, Room updatedRoomValues)
        {
            updatedRoomValues.Validate();
            room.Id = updatedRoomValues.Id;
            room.Price = updatedRoomValues.Price;
            room.LastCheckOut = updatedRoomValues.LastCheckOut;
            room.CurrentTenants = new Stack<Tenant>(updatedRoomValues.CurrentTenants);
            room.HasEnergyMeter = updatedRoomValues.HasEnergyMeter;
            room.EnergyMetering = new Stack<decimal>(updatedRoomValues.EnergyMetering);
            room.TenantsHistory = new Stack<Tenant>(updatedRoomValues.TenantsHistory);
        }

        public bool RemoveRoom(List<Room> rooms, int id)
        {
            if (rooms == null || rooms.Count == 0)
            {
                return false;
            }

            Room roomToRemove = rooms.FirstOrDefault(r => r.Id == id);

            if (roomToRemove == null)
            {
                return false;
            }

            return rooms.Remove(roomToRemove);
        }
    }
}
