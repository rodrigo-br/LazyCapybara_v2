namespace LazyCapybara_v2.Domain.Model
{
    public class Tenant
    {
        public Guid Id { get; set; }
#nullable disable
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
#nullable enable
        public int PaymantDay { get; set; }
        public DateOnly? CheckIn { get; set; }
        public DateOnly? CheckOut { get; set; }
    }
}
