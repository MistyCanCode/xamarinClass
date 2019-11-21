using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ControlEx.Model;

namespace ControlEx.Views.SimpleMasterDetail
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
		public DetailPage (Fruit fruit)
		{
			InitializeComponent ();
            if (fruit == null)
                throw new ArgumentException();
            BindingContext = fruit;
		}
	}
}