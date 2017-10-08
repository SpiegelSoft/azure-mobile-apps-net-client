using System.Reflection;
using Android.App;
using Android.OS;
using Xamarin.Android.NUnitLite;
using Xamarin.Forms.Platform.Android;

namespace Microsoft.WindowsAzure.Mobile.XamarinForms.Android
{
    [Activity(Label = "Microsoft.WindowsAzure.Mobile.XamarinForms.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }
    }
}

