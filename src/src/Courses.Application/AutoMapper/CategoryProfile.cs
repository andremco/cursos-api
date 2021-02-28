using AutoMapper;
using Courses.Application.ViewModels;
using Courses.Domain.Models.Category;

namespace Courses.Application.AutoMapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryViewModel, Category>().ForMember(s => s.Courses, d => d.Ignore()).ReverseMap();
        }
    }
}
