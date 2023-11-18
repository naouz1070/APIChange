using System.ComponentModel.DataAnnotations;

namespace APIChange.DTO
{
    public class AddressDTO
    {
        [Required]
        [StringLength(255)]
        public string Street { get; set; }

        [Required]
        [RegularExpression("\\d+")]
        public string Number { get; set; }
        [Required]
        [RegularExpression("\\d{4}")]
        public string ZipCode { get; set; }

        [Required]
        [StringLength(255)]
        public string City { get; set; }
    }
}
