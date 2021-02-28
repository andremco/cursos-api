using Courses.Domain.Attributes.Mongo;
using Courses.Domain.Models.Mongo;
using System.Collections.Generic;

namespace Courses.Domain.Models.Country
{
    [BsonCollection("countries")]
    public class Country : Document
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