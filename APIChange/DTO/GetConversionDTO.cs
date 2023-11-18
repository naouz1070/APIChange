using APIChange.Controllers.Validators;
using System.ComponentModel.DataAnnotations;

namespace APIChange.DTO
{
    public class GetConversionDTO
    {
        [Required]
        [Range (0, 999999)]
        public double Montant { get; set; }
        [Required]
        [Currency]
        public string Currency { get; set; }

    }
}
