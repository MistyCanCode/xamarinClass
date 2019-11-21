using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ControlEx.Model;

namespace ControlEx.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ActivitiesPage : ContentPage
	{

        public ActivitiesPage ()
		{
			InitializeComponent ();
            activitylistview.ItemsSource = GetUsers();
           // new NavigationPage(new UserProfilePage());
		}

        private IEnumerable GetUsers()
        {
            throw new NotImplementedException();
        }

        private void Listview_Refreshing(object sender, EventArgs e)
        {

        }

        private void Listview_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void Listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            new NavigationPage(new UserProfilePage());
        }
    }
}