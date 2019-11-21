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
	public partial class TableViewProject : ContentPage
	{
		public TableViewProject()
		{
			InitializeComponent();
		}

        private void Swi_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private void Contact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}