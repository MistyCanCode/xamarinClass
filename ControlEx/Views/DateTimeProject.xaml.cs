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
	public partial class DateTimeProject : ContentPage
	{
		public DateTimeProject()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            startdate.Focus();
        }

     

        private void Timebetween_Clicked(object sender, EventArgs e)
        {
            Enddate.Focus();
           GetTimeElapsed();
        }

        public void GetTimeElapsed()
        {
            TimeSpan timeElapsed = Enddate.Date - startdate.Date;
            resultLabel.Text = String.Format("{0} day{1} between dates", timeElapsed.Days, timeElapsed.Days == 1 ? "" : "s");
        }

        private void Date_DateSelected(object sender, DateChangedEventArgs e)
        {
            GetTimeElapsed();
        }

       
    }
}