using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Support.V4.App;
using Android.Support.V4.View;
using basicApp1.Tabs;
using FragmentManager = Android.Support.V4.App.FragmentManager;
using System;
using Fragment = Android.Support.V4.App.Fragment;

namespace basicApp1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : FragmentActivity, ActionBar.ITabListener
    {
        TextView txtNumber;
        int number = 0;

        private ActionBar ab;
        private ViewPager vp;
        private Adapter1 adapter;
        private FragmentManager fm;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //ab.NavigationMode = ActionBarNavigationMode.Tabs;
            //ab.SetDisplayShowTitleEnabled(true);

            //fm = this.SupportFragmentManager;

            //adapter = new Adapter1(fm, getPages());

            //vp = FindViewById<ViewPager>(Resource.Id.pager);
            //vp.PageSelected += Vp_PageSelected;

            //vp.Adapter = adapter;

            //AddTabs();

            txtNumber = FindViewById<TextView>(Resource.Id.txtNumber);

            FindViewById<Button>(Resource.Id.btnIncrement).Click += (o, e) =>
            txtNumber.Text = (++number).ToString();

            FindViewById<Button>(Resource.Id.btnDecrement).Click += (o, e) =>
            txtNumber.Text = (--number).ToString();

            EditText edtName = FindViewById<EditText>(Resource.Id.edtName);

            FindViewById<Button>(Resource.Id.btnNext).Click += (o, e) =>
                {
                    Intent nextActivity = new Intent(this, typeof(Activity2));
                    nextActivity.PutExtra("name", edtName.Text);
                    StartActivity(nextActivity);
                };

            //Android.App.ActionBar.Tab tab = ActionBar.NewTab();
            //tab.SetText("test1");
            ////tab.SetIcon(Resource.Drawable.tab1_icon);
            //tab.TabSelected += (sender, args) => {
            //    // Do something when tab is selected
            //};
            //ActionBar.AddTab(tab);

            //tab = ActionBar.NewTab();
            //tab.SetText("test2");
            ////tab.SetIcon(Resource.Drawable.tab2_icon);
            //tab.TabSelected += (sender, args) => {
            //    // Do something when tab is selected
            //};
            //ActionBar.AddTab(tab);
        }

        private void Vp_PageSelected(object sender, ViewPager.PageSelectedEventArgs e)
        {
            ab.SetSelectedNavigationItem(e.Position);
        }

        private JavaList<Android.Support.V4.App.Fragment> getPages()
        {
            JavaList<Fragment> pages = new JavaList<Fragment>();
            pages.Add(new Fragment1());
            pages.Add(new Fragment2());
            return pages;
        }

        private void AddTabs()
        {
            ActionBar.Tab t = ab.NewTab().SetText("1").SetTabListener(this);
            ab.AddTab(t);
            ActionBar.Tab t2 = ab.NewTab().SetText("2").SetTabListener(this);
            ab.AddTab(t2);
        }

        public void OnTabReselected(ActionBar.Tab tab, Android.App.FragmentTransaction ft)
        {
            
        }

        public void OnTabSelected(ActionBar.Tab tab, Android.App.FragmentTransaction ft)
        {
            vp.CurrentItem = tab.Position;
        }

        public void OnTabUnselected(ActionBar.Tab tab, Android.App.FragmentTransaction ft)
        {
            
        }
    }
}