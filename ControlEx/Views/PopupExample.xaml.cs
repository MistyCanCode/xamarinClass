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
	public partial class PopupExample : ContentPage
	{
		public PopupExample ()
		{
			InitializeComponent ();
		}
     async private void Button_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Confirmation", "Button Clicked", "Ok", "Cancel");
            if (response)
                await DisplayAlert("Done", response.ToString(), "Ok");
        }

        async private void Send_Clicked(object sender, EventArgs e)
        {
           var response= await DisplayActionSheet("Title", "Cancel", "Delete", "Copy", "Email Attachment", "Save to Device");
            await DisplayAlert("Response", response.ToString(), "Ok");
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Add Contact", "Ok");
        }

        private void ToolbarItem_Activated_1(object sender, EventArgs e)
        {

        }

        private void ToolbarItem_Activated_2(object sender, EventArgs e)
        {

        }
    }
}