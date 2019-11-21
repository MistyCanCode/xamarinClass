using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlEx.Model;
using ControlEx.Data;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlEx.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerPage1 : ContentPage
    {
        FruitData fruitData = new FruitData();
		public PickerPage1 ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            picker.ItemsSource = fruitData.GetFruits().ToList();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = (Fruit)picker.ItemsSource[picker.SelectedIndex];
            lblName.Text = data.Name.ToString();
            imgurl.Source = data.ImgUrl;
            lblDetails.Text = data.Details.ToString();
        }
    }
}