using Courses.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Courses.Application.Services.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryViewModel>> GetAllCountries();
        Task<CountryViewModel> InsertOrUpdateCountry(CountryViewModel countryViewModel);
    }
}
