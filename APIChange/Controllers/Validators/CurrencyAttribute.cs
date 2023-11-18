using APIChange.DTO;
using System.ComponentModel.DataAnnotations;

namespace APIChange.Controllers.Validators
{
    public class CurrencyAttribute : ValidationAttribute
    {
        public CurrencyAttribute()
        {
            ErrorMessage = "Impossible de convertir dans une autre valeur que Euro Yen ou Dollar";
        }

        public override bool IsValid(object? value)
        {
            if (value is null)
            {
                return true;
            }
            string val = (string)value;
            return val == "Euro" || val == "Yen" || val == "Dollar";
        }
    }
}
