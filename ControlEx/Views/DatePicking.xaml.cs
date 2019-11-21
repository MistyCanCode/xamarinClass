using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ControlEx.Model;
using ControlEx.Views;

namespace ControlEx.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DatePicking : ContentPage
	{
		public DatePicking ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            startdate.Focus();
        }

      
    }
}