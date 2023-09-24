using Common.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LazyCapybaraLibrary.Services
{
    public class ClassValidationsService : IValidation
    {
        public void ClassValidation(object instance)
        {
            ValidationContext context = new ValidationContext(instance, serviceProvider: null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(instance, context, results, true);

            if (isValid == false)
            {
                StringBuilder sbrErrors = new StringBuilder();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErrors.ToString());
            }
        }
    }
}