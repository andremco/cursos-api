using Courses.Domain.Models.Country;

namespace Courses.Domain.Interfaces.Repositories
{
    public interface ICountryRepository : IMongoRepository<Country>
    {
    }
}
