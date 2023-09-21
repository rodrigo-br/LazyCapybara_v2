namespace LazyCapybara_v2.Domain.Model
{
    public class Room
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public bool HasEnergyMeter { get; set; }
        public IEnumerable<decimal>? EnergyMetering { get; set; }
        public DateOnly LastCheckOut { get; set; }
        public ICollection<Tenant>? TenantsHistory { get; set; }
        public ICollection<Tenant>? CurrentTenants { get; set; }
    }
}
