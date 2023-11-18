using APIChange.DTO;
using System.ComponentModel.DataAnnotations;

namespace APIChange.Controllers.Validators
{
    public class LevelMinimumAttribute : ValidationAttribute
    {
        public LevelMinimumAttribute()
        {
            ErrorMessage = "Le skill C# est inférieur à 3 !";
        }
        public override bool IsValid(Object? value)
        {
            if (value == null)
            {
                return true;
            }

            if (value is SkillDTO[] skillDTO)
            {
                foreach(SkillDTO skill in skillDTO)
                {
                    if (skill.Name == "C#" && skill.Level < 3)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

            }
            return true;
        }
    }
}
