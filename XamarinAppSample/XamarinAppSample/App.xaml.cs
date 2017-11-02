using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinAppSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //global
            
            Application.Current.Properties["username"] = "anonymous";

            MainPage = new MyMasterDetailPage();
            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new NavigationPage(new KirimDataPage());
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
