using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinAppSample
{
    public partial class App : Application
    {
        /* Link setting IOS https://1drv.ms/w/s!AsrTz6LxdXjU3WgEXVWkSpocHS94 */
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
