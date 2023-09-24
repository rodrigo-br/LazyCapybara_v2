namespace Domain.Models
{
    using Common.Interfaces;
    using System.ComponentModel.DataAnnotations;

    public class Tenant
    {
        [Required]
        public Guid Id { get; set; }

#nullable disable
        [Required]
        [MinLength(3, ErrorMessage = "Nome precisa ter ao menos 3 letras")]
        [MaxLength(49, ErrorMessage = "Nome não pode ter mais de 49 caracteres")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Último nome precisa ter ao menos 3 letras")]
        [MaxLength(49, ErrorMessage = "Último nome não pode ter mais de 49 caracteres")]
        public string LastName { get; set; }

        [Required]
        [MinLength(11, ErrorMessage = "Telefone celular precisa ter ao menos 11 dígitos (incluir código de área)")]
        [MaxLength(49, ErrorMessage = "Telefone não pode ter mais de 49 caracteres")]
        public string PhoneNumber { get; set; }

        [Required]
        [RegularExpression("/^[a-z0-9.]+@[a-z0-9]+\\.[a-z]+\\.([a-z]+)?$/i", ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

#nullable enable
        [Required]
        [Range(0, 28)]
        public int PaymantDay { get; set; }

        public DateOnly? CheckIn { get; set; }

        public DateOnly? CheckOut { get; set; }

        private readonly IValidation _validation;

        public Tenant(IValidation validation)
        {
            _validation = validation;
        }

        public void Validate()
        {
            _validation.ClassValidation(this);
        }
    }
}
