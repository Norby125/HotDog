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
using NorbisHotDog.Droid.Utility;
using NorbisHotDog.Model;

namespace NorbisHotDog.Droid.Adapters
{
    class CartAdapter : BaseAdapter<CartItem>
    {
        private Activity _context;
        private List<CartItem> _items;

        public CartAdapter(Activity context, List<CartItem> items)
        {
            this._context = context;
            this._items = items;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];

            //var imageBitmap = ImageHelper.GetImageBitmapFromUrl("http://gillcleerenpluralsight.blob.core.windows.net/files/" + item.HotDog.ImagePath + ".jpg");

            if (convertView == null)
            {
                convertView = _context.LayoutInflater.Inflate(Resource.Layout.CartRowView, null);
            }

            convertView.FindViewById<TextView>(Resource.Id.hotDogNameTextView).Text = item.HotDog.Name;
            convertView.FindViewById<TextView>(Resource.Id.amountTextView).Text = item.Amount.ToString();
           // convertView.FindViewById<ImageView>(Resource.Id.hotDogImageView).SetImageBitmap(imageBitmap);

            return convertView;
        }

        public override int Count
        {
            get { return _items.Count; }
        }

        public override CartItem this[int position]
        {
            get
            {
                return _items[position];
            }
        }
    }
}