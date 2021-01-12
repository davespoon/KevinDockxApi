using System.ComponentModel.DataAnnotations;
using KevinDockx.API.ValidationAttributes;

namespace KevinDockx.API.Models
{
    [CourseTitleMustBeDifferentFromDescription(ErrorMessage = "Title must be different from description.")]
    public abstract class CourseForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out title.")]
        [MaxLength(100, ErrorMessage = "Title shouldn't have more than 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "You should fill out description.")]
        [MaxLength(1500, ErrorMessage = "The description shouldn't have more than 1500 characters.")]
        public virtual string Description { get; set; }
    }
}