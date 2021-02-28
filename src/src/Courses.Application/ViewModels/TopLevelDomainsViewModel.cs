using System.Collections.Generic;

namespace Courses.Application.ViewModels
{
    public class TopLevelDomainsViewModel
    {
        public string Name { get; set; }

        public ICollection<TopLevelDomainsCountriesViewModel> Countries { get; set; }

        public TopLevelDomainsViewModel()
        {
            Countries = new HashSet<TopLevelDomainsCountriesViewModel>();
        }
    }
}
