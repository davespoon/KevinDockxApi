using System.ComponentModel.DataAnnotations;
using KevinDockx.API.Models;

namespace KevinDockx.API.ValidationAttributes
{
    public class CourseTitleMustBeDifferentFromDescriptionAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var course = validationContext.ObjectInstance as CourseForCreationDto;

            if (course.Title == course.Description)

            {
                return new ValidationResult(ErrorMessage,
                    new[] {nameof(CourseForCreationDto)});
            }

            return ValidationResult.Success;
        }
    }
}