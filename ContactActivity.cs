
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
    [Activity(Label = "ContactActivity")]
    public class ContactActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.contactBloger);

            Button btnEmail = FindViewById<Button>(Resource.Id.btn_email);

            btnEmail.Click += delegate {


                var email = new Intent(Android.Content.Intent.ActionSend);
                email.PutExtra(Android.Content.Intent.ExtraEmail, new string[] { "arkiz79@gmail.com" });
                email.PutExtra(Android.Content.Intent.ExtraCc, new string[] { "c0660544@mylambton.ca" });
                email.PutExtra(Android.Content.Intent.ExtraSubject, "Hello Email");
                email.PutExtra(Android.Content.Intent.ExtraText, "Hello Kiyoung");
                email.SetType("message/rfc822");
                StartActivity(email);

            };

            Button btnPhone = FindViewById<Button>(Resource.Id.btn_phone);

            btnPhone.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("tel:6479697979");
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);

            };
        }
    }
}
