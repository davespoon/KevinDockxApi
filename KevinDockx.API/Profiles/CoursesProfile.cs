using AutoMapper;

namespace KevinDockx.API.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Entities.Course, Models.CourseDto>();
            CreateMap<Entities.Course, Models.AuthorForCreationDto>();
        }
    }
}