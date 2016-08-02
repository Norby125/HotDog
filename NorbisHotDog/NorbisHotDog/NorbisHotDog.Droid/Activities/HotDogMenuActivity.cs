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
using Mono.Data.Sqlite;
using NorbisHotDog.Droid.Adapters;
using NorbisHotDog.Model;
using NorbisHotDog.Service;

namespace NorbisHotDog.Droid.Activities
{
    [Activity(Label = "HotDogMenuActivity")]
    public class HotDogMenuActivity : Activity
    {
        private ListView _hotDogListView;
        private List<HotDog> _allHotDogs;
        private HotDogDataService _hotDogDataService;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.HotDogMenuView);

            _hotDogListView = FindViewById<ListView>(Resource.Id.hotDogListView);
            _hotDogDataService = new HotDogDataService();

            _allHotDogs = _hotDogDataService.GetAllHotDogs();

            _hotDogListView.Adapter = new HotDogListAdapter(this, _allHotDogs);
            _hotDogListView.ItemClick+=HotDogListViewOnClick;
            _hotDogListView.FastScrollEnabled = true;
        }

        private void HotDogListViewOnClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var hotDog = _allHotDogs[e.Position];

            var intent = new Intent();
            intent.SetClass(this, typeof(HotDogDetailActivity));
            intent.PutExtra("selectedHotDogId", hotDog.Id);

            StartActivityForResult(intent, 100);
        }
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (resultCode == Result.Ok && requestCode == 100)
            {
                var selectedHotDog = _hotDogDataService.GetHotDogById(data.GetIntExtra("selectedHotDogId", 0));

                var dialog = new AlertDialog.Builder(this);
                dialog.SetTitle("Confirmation");
                dialog.SetMessage(string.Format("You've added {0} time(s) the {1}", data.GetIntExtra("amount", 0), selectedHotDog.Name));
                dialog.Show();
            }
        }
    }
}