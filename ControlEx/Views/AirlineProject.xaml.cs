using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ControlEx.Model;
using System.Collections.Generic;
using ControlEx.Service;

namespace ControlEx.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirlineProject : ContentPage
    { 
        public AirlineProject()
        {
            InitializeComponent();
        }
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
            if(string.IsNullOrWhiteSpace(searchText))
                return entries;
            return entries.Where(f => f.From_Location.StartsWith(searchText, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private void MyListView_Refreshing(object sender, EventArgs e)
        {

        }

        private void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            MyListView.ItemsSource = GetEntries(e.NewTextValue);
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var search = (sender as MenuItem).CommandParameter as SearchModel;
            
        }
    }
}
