
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

namespace TravelBlog2nd
{
    [Activity(Label = "CountryListActivity")]
    public class CountryListActivity : Activity
    {
        List<TableItem> tableItems = new List<TableItem>();

        ListView listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.listScreen);

            listView = FindViewById<ListView>(Resource.Id.List);

            string listType = Intent.GetStringExtra("list_type") ?? "Data not available";

            getCountryList(listType);

            listView.ItemClick += OnListItemClick;

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            //Toolbar will now take on default actionbar characteristics
            //SetActionBar(toolbar);
            ActionBar.Title = "";

            toolbar.InflateMenu(Resource.Menu.home);
            toolbar.MenuItemClick += (sender, e) => {
                Toast.MakeText(this, e.Item.TitleFormatted.ToString(), ToastLength.Short).Show();


                if (e.Item.TitleFormatted.ToString() == "HOME")
                {
                    StartActivity(new Intent(Application.Context, typeof(MainActivity)));
                }
                else if (e.Item.TitleFormatted.ToString() == "TRIP:LOG")
                {
                    getCountryList("triplog");

                }
                else if (e.Item.TitleFormatted.ToString() == "PLAN")
                {
                    getCountryList("plan");

                }
                else if (e.Item.TitleFormatted.ToString() == "Contact")
                {
                    StartActivity(new Intent(Application.Context, typeof(ContactActivity)));
                }
            };

        }

        private void getCountryList(string listType)
        {
            tableItems.Clear();
            if (listType == "triplog")
            {
                tableItems.Add(new TableItem() { Heading = "Seoul", SubHeading = "South Korea", ImageResourceId = Resource.Drawable.kr });
                tableItems.Add(new TableItem() { Heading = "Toronto", SubHeading = "Canada", ImageResourceId = Resource.Drawable.ca });
                tableItems.Add(new TableItem() { Heading = "Quebec", SubHeading = "Canada", ImageResourceId = Resource.Drawable.ca });
                tableItems.Add(new TableItem() { Heading = "Paris", SubHeading = "France", ImageResourceId = Resource.Drawable.fr });
                tableItems.Add(new TableItem() { Heading = "Rome", SubHeading = "Italy", ImageResourceId = Resource.Drawable.it });
                tableItems.Add(new TableItem() { Heading = "Lucerne", SubHeading = "Switzerland", ImageResourceId = Resource.Drawable.ch });

            }
            else if (listType == "plan")
            {

                tableItems.Add(new TableItem() { Heading = "NewYork", SubHeading = "Unite States", ImageResourceId = Resource.Drawable.us });
                tableItems.Add(new TableItem() { Heading = "London", SubHeading = "England", ImageResourceId = Resource.Drawable.gr });
                tableItems.Add(new TableItem() { Heading = "New Delhi", SubHeading = "India", ImageResourceId = Resource.Drawable.india });
                tableItems.Add(new TableItem() { Heading = "Mexico City", SubHeading = "Mexico", ImageResourceId = Resource.Drawable.mx });
                tableItems.Add(new TableItem() { Heading = "Moscow", SubHeading = "Russia", ImageResourceId = Resource.Drawable.ru });
                tableItems.Add(new TableItem() { Heading = "Taipei", SubHeading = "Taiwan", ImageResourceId = Resource.Drawable.tw });

            }

            listView.Adapter = new ScreenAdapter(this, tableItems);
        }

        protected void OnListItemClick(object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
        {
            var t = tableItems[e.Position];
            Android.Widget.Toast.MakeText(this, t.Heading, Android.Widget.ToastLength.Short).Show();
            Console.WriteLine("Clicked on " + t.Heading);

            var countryInfoactivity = new Intent(this, typeof(CountryInfoActivity));
            countryInfoactivity.PutExtra("city_name", t.Heading);
            StartActivity(countryInfoactivity);


        }

        //public override bool OnCreateOptionsMenu(IMenu menu)
        //{
        //    MenuInflater.Inflate(Resource.Menu.home, menu);
        //    return base.OnCreateOptionsMenu(menu);
        //}

    }
}