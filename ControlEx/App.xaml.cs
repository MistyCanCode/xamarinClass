using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ControlEx.Views;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ControlEx
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            //MainPage = new ControlPage1();
            //MainPage = new ControlPage2();
            // MainPage = new PickerPage1();
            // MainPage = new DatePicking();
            // MainPage = new Views.DateTime();
            //MainPage = new ListViewEx
            // MainPage = new TableViewProject();
            /*  MainPage = new NavigationPage(new WelcomePage())
              {
                  BarBackgroundColor = Color.Gray,
                  BarTextColor = Color.Red,

              };*/
            // MainPage = new TabbedPageEx();
            // MainPage = new CarouselPageEx();
             MainPage = new NavigationPage(new PopupExample());
            // MainPage = new MasterPage();
            // MainPage = new MasterDetailPage();
            //MainPage = new AirlineProject();
             //MainPage = new NavigationPage(new Navigation_Project());
           // MainPage = new DateTimeProject();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
