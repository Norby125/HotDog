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
    public class HotDogListAdapter : BaseAdapter<HotDog>
    {
        private List<HotDog> _items;
        private Activity _context;

        public HotDogListAdapter(Activity context, List<HotDog> items)
        {
            this._items = items;
            this._context = context;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];

            if (convertView == null)
            {
                convertView = _context.LayoutInflater.Inflate(Resource.Layout.HotDogRowView, null);
            }
            //var imageBitmap = ImageHelper.GetImageBitmapFromUrl("http://www.beautytour.info/wp-content/uploads/2016/02/Hot-Dog.jpg");
            convertView.FindViewById<TextView>(Resource.Id.hotDogNameTextView).Text = item.Name;
            convertView.FindViewById<TextView>(Resource.Id.shortDescriptionTextView).Text = item.ShortDescription;
            convertView.FindViewById<TextView>(Resource.Id.priceTextView).Text = "$ " + item.Price;
            //convertView.FindViewById<ImageView>(Resource.Id.hotDogImageView).SetImageBitmap(imageBitmap);
            return convertView;

        }

        public override int Count => _items.Count;

        public override HotDog this[int position] => _items[position];


    }
}