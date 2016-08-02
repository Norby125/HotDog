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

namespace NorbisHotDog.Droid.Activities
{
    [Activity(Label = "Norbi's Hot Dogs",  Icon = "@drawable/icon")]
    class MainActivity : Activity
    {
        private Button _orderHotDogsButton;
        private Button _viewChartButton;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.MainView);

            // Get our button from the layout resource,
            // and attach an event to it
            FindViews();
            HadleEvents();

        }

        private void HadleEvents()
        {
            _orderHotDogsButton.Click += OrderHotDogsButtonOnClick;
            _viewChartButton.Click += ViewChartButtonOnClick;

        }

        private void ViewChartButtonOnClick(object sender, EventArgs eventArgs)
        {
            var intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }

        private void OrderHotDogsButtonOnClick(object sender, EventArgs eventArgs)
        {
            var intent = new Intent(this, typeof(HotDogMenuActivity));
            StartActivity(intent);

        }

        private void FindViews()
        {
            _orderHotDogsButton = FindViewById<Button>(Resource.Id.orderHotDogsButton);
            _viewChartButton = FindViewById<Button>(Resource.Id.viewChartButton);
        }

    }
}