namespace LazyCapybara_v2.Security.Dto
{
    using Domain.Models;

    public class RoomDto
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public bool HasEnergyMeter { get; set; }

        public decimal EnergyMetering { get; set; }

        public Stack<Tenant> CurrentTenants { get; set; } = new Stack<Tenant>();
    }
}
