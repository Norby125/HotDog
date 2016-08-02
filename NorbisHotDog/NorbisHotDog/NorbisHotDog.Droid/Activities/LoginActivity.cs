using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

namespace NorbisHotDog.Droid.Activities
{
    [Activity(Label = "Login", Theme = "@style/MainTheme", MainLauncher = true, NoHistory = true)]
    public class LoginActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            Xamarin.Forms.Forms.Init(this, savedInstanceState);

            var xApp = new NorbisHotDog.App();
            xApp.LoadMainPage();
            LoadApplication(xApp);
        }
    }
}