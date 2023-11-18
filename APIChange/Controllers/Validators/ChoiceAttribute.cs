using System.ComponentModel.DataAnnotations;

namespace APIChange.Controllers.Validators
{
    public class ChoiceAttribute : ValidationAttribute
    {
        public string[] Choices { get; }
        public ChoiceAttribute(params string[] choices)
        {
            Choices = choices;
        }

        public override bool IsValid(object? value)
        {
            if(Choices is null)
            {
                return true;
            }

            return Choices.Contains((string)value);

        }
    }
}
