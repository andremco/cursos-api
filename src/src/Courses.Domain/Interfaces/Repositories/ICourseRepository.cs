using Courses.Domain.Models.Category;
using Courses.Domain.Models.Course;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Courses.Domain.Interfaces.Repositories
{
    public interface ICourseRepository : IEntityBaseRepository<Course>
    {
        Task<IEnumerable<Course>> GetAllAsync();
        Task<Course> GetByIdAsync(int id);
    }
}
