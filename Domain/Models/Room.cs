namespace Domain.Models
{
    using Common.Interfaces;
    using System.ComponentModel.DataAnnotations;

    public class Room
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Range(minimum:450, maximum:double.MaxValue, ErrorMessage = "Valor de aluguel inválido. Corrija ou contate o administrador")]
        public decimal Price { get; set; }

        [Required]
        public bool HasEnergyMeter { get; set; }

        public Stack<decimal> EnergyMetering { get; set; } = new Stack<decimal>();

        [Required]
        public DateOnly LastCheckOut { get; set; }

        public Stack<Tenant> TenantsHistory { get; set; } = new Stack<Tenant>();

        public Stack<Tenant> CurrentTenants { get; set; } = new Stack<Tenant>();

        private readonly IValidation _validation;

        public Room(IValidation validation)
        {
            _validation = validation;
        }

        public void Validate()
        {
            _validation.ClassValidation(this);
        }
    }
}
