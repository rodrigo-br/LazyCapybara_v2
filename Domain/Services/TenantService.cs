using Common.Interfaces;
using Domain.Models;

namespace Domain.Services
{
    public class TenantService
    {
        private readonly IValidation _validation;

        public TenantService(IValidation validation)
        {
            _validation = validation;
        }

        public Tenant CreateEmptyTenant()
        {
            return new Tenant(_validation)
            {
                Id = Guid.Empty,
                FirstName = string.Empty,
                LastName = string.Empty,
                PhoneNumber = string.Empty,
                Email = string.Empty,
                PaymantDay = 0,
                CheckIn = null,
                CheckOut = null
            };
        }

        public Tenant CreateNewTenant(
            string firstName,
            string lastName,
            string phoneNumber,
            string email,
            int paymantDay,
            DateOnly? checkIn)
        {
            var checkInDate = checkIn ?? DateOnly.FromDateTime(DateTime.Now);

            return new Tenant(_validation)
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Email = email,
                PaymantDay = paymantDay,
                CheckIn = checkInDate,
                CheckOut = null
            };
        }
    }
}
