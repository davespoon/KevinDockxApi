using System.ComponentModel.DataAnnotations;

namespace KevinDockx.API.Models
{
    public class CourseForUpdateDto : CourseForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out description.")]
        public override string Description
        {
            get => base.Description;
            set => base.Description = value;
        }
    }
}