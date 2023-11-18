using APIChange.Controllers.Validators;
using System.ComponentModel.DataAnnotations;

namespace APIChange.DTO
{
    public class SkillDTO
    {
        [Required]
        [Choice("C#", "JS", "React", "Angular", "Java")]
        public string Name { get; set; }


        [Required]
        [Range(1, 5)]
        public int Level { get; set; }
    }
}
