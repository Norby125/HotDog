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
using NorbisHotDog.Droid.Adapters;
using NorbisHotDog.Model;
using NorbisHotDog.Service;

namespace NorbisHotDog.Droid.Activities
{
    [Activity(Label = "CartActivity")]
    public class CartActivity : Activity
    {
        private ListView _cartListView;
        private List<CartItem> _cartItems;
        private CartDataService _cartDataService;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.CartView);

            _cartDataService=new CartDataService();
            _cartListView = FindViewById<ListView>(Resource.Id.cartListView);
            _cartItems = _cartDataService.GetCart().CartItems;
            _cartListView.Adapter=new CartAdapter(this,_cartItems);

        }
    }
}