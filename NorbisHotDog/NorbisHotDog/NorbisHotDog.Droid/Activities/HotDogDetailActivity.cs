using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using NorbisHotDog.Droid.Utility;
using NorbisHotDog.Model;
using NorbisHotDog.Service;

namespace NorbisHotDog.Droid.Activities
{
    [Activity(Label = "HotDogDetailActivity")]
    public class HotDogDetailActivity : Activity
    {
        private ImageView _hotDogImageView;
        private TextView _hotDogNameTextView;
        private TextView _shortDescriptionTextView;
        private TextView _descriptionTextView;
        private TextView _priceTextView;
        private EditText _amountEditText;
        private Button _cancelButton;
        private Button _orderButton;
        private HotDog _selectedHotDog;
        private HotDogDataService _dataService;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.HotDogDetailView);

            var selectedHotDogId = Intent.Extras.GetInt("selectedHotDogId");

            _dataService = new HotDogDataService();
            _selectedHotDog = _dataService.GetHotDogById(selectedHotDogId);

            FindViews();

            BindData();

            HandleEvents();

        }

        private void BindData()
        {
            _hotDogNameTextView.Text = _selectedHotDog.Name;
            _shortDescriptionTextView.Text = _selectedHotDog.ShortDescription;
            _descriptionTextView.Text = _selectedHotDog.Description;
            _priceTextView.Text = "Price: " + _selectedHotDog.Price;

            //_hotDogImageView.SetImageBitmap();

        }

        private void HandleEvents()
        {
            _orderButton.Click += (sender, args) =>
            {
                var amount = Int32.Parse(_amountEditText.Text);
                AddToChart(_selectedHotDog, amount);

                var intent = new Intent();
                intent.PutExtra("selectedHotDogId", _selectedHotDog.Id);
                intent.PutExtra("amount", amount);

                SetResult(Result.Ok, intent);

                Finish();
            };
            _cancelButton.Click+= delegate(object sender, EventArgs args)
            {
                SetResult(Result.Canceled);
                Finish();
            };
        }

        private void AddToChart(HotDog hotDog, int amount)
        {
            CartDataService cartDataService= new CartDataService();
            cartDataService.AddCartItem(hotDog, amount);
        }

        private void FindViews()
        {
            _hotDogImageView = FindViewById<ImageView>(Resource.Id.hotDogImageView);
            _hotDogNameTextView = FindViewById<TextView>(Resource.Id.hotDogNameTextView);
            _shortDescriptionTextView = FindViewById<TextView>(Resource.Id.shortDescriptionTextView);
            _descriptionTextView = FindViewById<TextView>(Resource.Id.descriptionTextView);
            _priceTextView = FindViewById<TextView>(Resource.Id.priceTextView);
            _amountEditText = FindViewById<EditText>(Resource.Id.amountEditText);
            _cancelButton = FindViewById<Button>(Resource.Id.cancelButton);
            _orderButton = FindViewById<Button>(Resource.Id.orderButton);
        }
    }
}