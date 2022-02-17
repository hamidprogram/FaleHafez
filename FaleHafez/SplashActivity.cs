using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace FaleHafez
{
    [Activity(Label = "فال حافظ", MainLauncher = true, NoHistory = true, Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen")]
    public class SplashActivity : Activity
    {
        Timer timer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SplashLayout);
            timer = new Timer();
            timer.Interval = 5000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            StartActivity(typeof(MineActivity));
        }
    }
}