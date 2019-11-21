using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlEx
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutUs : ContentPage
	{
		public AboutUs ()
		{
			InitializeComponent ();
		}

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

       async private void Button_Clicked(object sender, EventArgs e)
       {
            await Navigation.PopModalAsync();
       }
    }
}