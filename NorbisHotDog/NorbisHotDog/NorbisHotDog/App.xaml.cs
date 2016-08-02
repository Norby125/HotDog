using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorbisHotDog.Pages;
using Xamarin.Forms;

namespace NorbisHotDog
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage=new ContentPage();
        }

        public void LoadMainPage()
        {
            MainPage = new LoginPage();
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
