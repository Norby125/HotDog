using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.View;
using Android.Views;
using Android.Widget;
using NorbisHotDog;
using NorbisHotDog.Droid;
using NorbisHotDog.Droid.Activities;
using NorbisHotDog.Pages;

[assembly: Xamarin.Forms.Dependency(typeof(ContinueAndroid))]
namespace NorbisHotDog.Droid
{

    public class ContinueAndroid : Activity,IContinueAndroid
    {

        public void StartIntent()
        {
            var intent=new Intent(Android.App.Application.Context, typeof(HotDogMenuActivity));
            StartActivity(intent);
        }
    }
}