using Foundation;
using Google.MobileAds;

namespace TestInterstitialIOS;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp()
    {
        var app = MauiProgram.CreateMauiApp();
        
        // Initialize Google AdMob
        MobileAds.SharedInstance.Start(completionHandler: null);

        return app;
    }

}
