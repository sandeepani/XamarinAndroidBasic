using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace basicApp1.Tabs
{
    class Adapter1 : FragmentPagerAdapter
    {

        //Context context;

        //public Adapter1(Context context)
        //{
        //    this.context = context;
        //}


        //public override Java.Lang.Object GetItem(int position)
        //{
        //    return position;
        //}

        //public override long GetItemId(int position)
        //{
        //    return position;
        //}

        //public override View GetView(int position, View convertView, ViewGroup parent)
        //{
        //    var view = convertView;
        //    Adapter1ViewHolder holder = null;

        //    if (view != null)
        //        holder = view.Tag as Adapter1ViewHolder;

        //    if (holder == null)
        //    {
        //        holder = new Adapter1ViewHolder();
        //        var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
        //        //replace with your item and your holder items
        //        //comment back in
        //        //view = inflater.Inflate(Resource.Layout.item, parent, false);
        //        //holder.Title = view.FindViewById<TextView>(Resource.Id.text);
        //        view.Tag = holder;
        //    }


        //    //fill in your items
        //    //holder.Title.Text = "new text here";

        //    return view;
        //}

        ////Fill in cound here, currently 0
        //public override int Count
        //{
        //    get
        //    {
        //        return 0;
        //    }
        //}

        private JavaList<Fragment> fragments;

        public Adapter1(FragmentManager fm, JavaList<Fragment> fragments) : base(fm)
        {
            this.fragments = fragments;
        }

        public override int Count => fragments.Size();

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return fragments[position];
        }
    }

    //class Adapter1ViewHolder : Java.Lang.Object
    //{
    //    //Your adapter views to re-use
    //    //public TextView Title { get; set; }
    //}
}