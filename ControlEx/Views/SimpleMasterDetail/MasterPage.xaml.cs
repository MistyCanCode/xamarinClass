using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ControlEx.Views;
using ControlEx.Model;
using ControlEx.Data;
using ControlEx.Views.SimpleMasterDetail;

namespace ControlEx.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        public List<Fruit> GetFruits(string searchText = null)
        {
            //private ObservableCollection<Fruit> _fruit;
            List<Fruit> fruits = new List<Fruit>
            {
                new Fruit{ Name="Apple", Details = "Color in Red"},
                new Fruit{ Name="Banana", Details="Yellow in color"},
                new Fruit{ Name="Orange", Details="Orange in color"},
                new Fruit{ Name="Strawberry", Details="Yellow in color"},
                new Fruit{ Name="Pineapple", Details="Yellow in color"},
                new Fruit{ Name="Mango", Details="Yellow in color"},
                new Fruit{ Name="Melon", Details="Red in color"}
            };

            if (string.IsNullOrWhiteSpace(searchText))

                return fruits;
            return fruits.Where(f => f.Name.StartsWith(searchText, StringComparison.CurrentCultureIgnoreCase)).ToList();

            // return fruits;
        }
        public MasterPage()
        {
            InitializeComponent();
            listview.ItemsSource = GetFruits();
        }


       

        private void Listview_Refreshing(object sender, EventArgs e)
        {
           // listView.ItemsSource = GetFruits();
           // listView.EndRefresh();//this method internally sets IsRefreshing to false
                                  //ListView.IsRefreshingProperty = false;
        }


        private void Listview_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        async private void Listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var fruit = e.SelectedItem as Fruit;
            await Navigation.PushAsync(new DetailPage(fruit));
            listview.SelectedItem = null;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listview.ItemsSource = GetFruits(e.NewTextValue);
           //GetFruits method is called through a parameter
           //It means list will be returned if matching elements are present
        }

        //fruit = new ObservableCollection<Fruit>
        // {
        // new Fruit{ Name="Apple", Details = "Color in Red"},
        // new Fruit{ Name="Banana", Details="Yellow in color"},
        // new Fruit{ Name="Mango", Details="Yellow in color"},
        // new Fruit{ Name="Melon", Details="Red in color"}
        //  };
   

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var fruit = (sender as MenuItem).CommandParameter as Fruit;
             //_fruit.Remove(fruit);
        }
    }
}

  