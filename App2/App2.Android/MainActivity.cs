using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using System.Threading.Tasks;
using Rollbar;

namespace App2.Droid
{
    [Activity(Label = "App2", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
          //  ConfigureRollbarSingleton();
            base.OnCreate(bundle);
            // AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            // TaskScheduler.UnobservedTaskException += TaskSchedulerOnUnobservedTaskException;
            try
            {
                var sdCardPath = Android.OS.Environment.ExternalStorageDirectory.Path;
                var filePath = System.IO.Path.Combine(sdCardPath, "iootext.txt");
                if (!System.IO.File.Exists(filePath))
                {
                    using (System.IO.StreamWriter write = new System.IO.StreamWriter(filePath, true))
                    {
                        write.Write("yttqyqfdwdfqhhgqhgachgCAHGCAAHG");
                    }
                }
            }catch(Exception e)
            {

            }

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

