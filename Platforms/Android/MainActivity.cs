using Android.App;
using Android.Content.PM;
using Android.OS;


namespace OneMoreDate
{
    [Activity(Theme = "@style/Maui.SplashTheme",
       MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestedOrientation = ScreenOrientation.Portrait;
            //  tvingar aktiviteten att alltid visas i porträttläge, vilket förhindrar att den roterar till liggande läge.
        }



    }
}