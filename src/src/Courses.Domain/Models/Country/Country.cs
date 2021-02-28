using System.Collections.Generic;

namespace Courses.Domain.Models.Country
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public long Area { get; set; }
        public long Population { get; set; }
        public float PopulationDensity { get; set; }
        public ICollection<TopLevelDomains> TopLevelDomains { get; set; }

        public Country()
        {
            TopLevelDomains = new HashSet<TopLevelDomains>();
        }
    }
}