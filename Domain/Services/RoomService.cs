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
            room.Id = updatedRoomValues.Id;
            room.Price = updatedRoomValues.Price;
            room.LastCheckOut = updatedRoomValues.LastCheckOut;
            room.CurrentTenants = new Stack<Tenant>(updatedRoomValues.CurrentTenants);
            room.HasEnergyMeter = updatedRoomValues.HasEnergyMeter;
            room.EnergyMetering = new Stack<decimal>(updatedRoomValues.EnergyMetering);
            room.TenantsHistory = new Stack<Tenant>(updatedRoomValues.TenantsHistory);
        }
    }
}
