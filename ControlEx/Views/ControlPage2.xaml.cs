using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlEx.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ControlPage2 : ContentPage
	{
		public ControlPage2 ()
		{
			InitializeComponent ();
		}

        private void Swi_Toggled(object sender, ToggledEventArgs e)
        {
            lblswi.TextColor = e.Value ? Color.Purple : Color.PowderBlue;
        }

        private void Txtusername_Completed(object sender, EventArgs e)
        {
            lblusername.Text = "completed" + e.ToString();
        }

        private void Txtpassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblpassword.Text = e.NewTextValue;
        }
    }
}