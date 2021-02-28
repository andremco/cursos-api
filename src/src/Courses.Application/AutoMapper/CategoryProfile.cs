using AutoMapper;
using Courses.Application.ViewModels;
using Courses.Domain.Models.Category;
using Courses.Domain.Models.Course;

namespace Courses.Application.AutoMapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryViewModel, Category>().ForMember(s => s.Courses, d => d.Ignore()).ReverseMap();

            CreateMap<CourseViewModel, Course>()
                .ForMember(s => s.Category, d => d.Ignore());
            CreateMap<Course, CourseViewModel>();


        }
    }
}
