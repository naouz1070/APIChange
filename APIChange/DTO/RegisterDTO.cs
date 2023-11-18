using APIChange.Controllers.Validators;
using System.ComponentModel.DataAnnotations;

namespace APIChange.DTO
{
    public class RegisterDTO
    {
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime DateDeNaissance { get; set; }

        [Required]
        
        public AddressDTO Address { get; set; }

        //[MaxLength(10)]
        [LevelMinimum]
        public SkillDTO[] Skills { get; set; }
    }
}
