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

namespace basicApp1
{
    [Activity(Label = "Activity2")]
    public class Activity2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_2);

            string name = Intent.GetStringExtra("name" ?? "Not recv");
            var tName = FindViewById<TextView>(Resource.Id.txtIntro2);

            tName.Text = name;

            FindViewById<Button>(Resource.Id.btnPrevious).Click += delegate { this.Finish(); };
        }
    }
}