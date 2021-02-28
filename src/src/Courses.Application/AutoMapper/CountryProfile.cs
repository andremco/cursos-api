using AutoMapper;
using Courses.Application.ViewModels;
using Courses.Domain.Models.Country;

namespace Courses.Application.AutoMapper
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryViewModel>()
                .ForMember(s => s.Id, d => d.MapFrom(d => d.CountryId));

            CreateMap<CountryViewModel, Country>()
                .ForMember(s => s.CountryId, d => d.MapFrom(c => c.Id))
                .ForMember(s => s.Id, d => d.Ignore());

            CreateMap<TopLevelDomainsViewModel, TopLevelDomains>().ReverseMap();
            CreateMap<TopLevelDomainsCountriesViewModel, TopLevelDomainsCountries>().ReverseMap();
        }
    }
}
