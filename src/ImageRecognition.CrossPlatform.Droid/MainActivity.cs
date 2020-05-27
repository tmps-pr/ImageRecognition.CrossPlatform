using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Acr.UserDialogs;
using FFImageLoading.Forms.Platform;
using MvvmCross.Forms.Platforms.Android.Views;
using Xamarin.Forms;
using ImageRecognition.CrossPlatform.Core;
using ImageRecognition.CrossPlatform.UI;

namespace ImageRecognition.CrossPlatdorm.Droid.Droid
{
    [Activity(
        Icon = "@mipmap/icon",
        Theme = "@style/AppTheme",
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        LaunchMode = LaunchMode.SingleTask,
        MainLauncher = true)]
    public class MainActivity : MvxFormsAppCompatActivity<Setup, CoreApp, App>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            Forms.Init(this, savedInstanceState);
            UserDialogs.Init(this);
            CachedImageRenderer.Init(true);
            base.OnCreate(savedInstanceState);

           
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}