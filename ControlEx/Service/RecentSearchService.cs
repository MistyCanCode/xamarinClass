using System;
using System.Collections.Generic;
using System.Text;
using ControlEx.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using System.Collections;

namespace ControlEx.Service
{
    class RecentSearchService : IEnumerable
    {
        public List<SearchModel> GetEntries(string searchText = null)
        {
            List<SearchModel> entries = new List<SearchModel>
            {
                new SearchModel{From_Location="Atlanta, GA", To_Location="Denver, CO", From_Date=DateTime.Parse("Jun 2, 2019"), To_Date=DateTime.Parse("Jun 17, 2019")},
                new SearchModel{From_Location="Nashville, TN", To_Location="NewYork, NY", From_Date=DateTime.Parse("May 12, 2019"), To_Date=DateTime.Parse("May 17, 2019")},
                new SearchModel{From_Location="LasVegas,NV", To_Location="Jacksonville, FL", From_Date=DateTime.Parse("Apr 20, 2019"), To_Date=DateTime.Parse("Apr 27, 2019")},
                new SearchModel{From_Location="Panama City, FL", To_Location="Park City, UT", From_Date=DateTime.Parse("Jan 15, 2020"), To_Date=DateTime.Parse("Jan 20, 2020")},
                new SearchModel{From_Location="Birmingham, AL", To_Location="New Orleans, LA", From_Date=DateTime.Parse("Aug 1, 2020"), To_Date=DateTime.Parse("Aug 4, 2020")}
            };
            if (string.IsNullOrWhiteSpace(searchText))
                return entries;
            return entries.Where(f => f.From_Location.StartsWith(searchText, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return GetRecentSearches();
        }

        public IEnumerable<SearchModel>GetRecentSearches(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter))
                return GetRecentSearches();
            return GetRecentSearches().Where(f => f.From_Location.StartsWith(filter, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        void DeleteSearch(SearchModel search)
        {
            var result = (search as SearchModel);
        }
    }
}
