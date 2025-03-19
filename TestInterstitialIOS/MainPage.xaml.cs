using Plugin.AdMob;
using Plugin.AdMob.Configuration;
using Plugin.AdMob.Services;

namespace TestInterstitialIOS;

public partial class MainPage : ContentPage
{
	private static IInterstitialAdService _interstitialAdService = default!;

	public MainPage()
	{
		InitializeComponent();

		// using test ad
		AdConfig.UseTestAdUnitIds = true;

		// get service
        _interstitialAdService = ServiceProvider.GetRequiredService<IInterstitialAdService>();

	}

	private async void OpenModalClicked(object sender, EventArgs e){
		await Navigation.PushModalAsync(new ModalPage());
	}

	public void ShowInterstitialAd(object sender, EventArgs e){
		LoadAndShowInterstitial();
    }

	public static void LoadAndShowInterstitial(){
        var interstitialAd = _interstitialAdService.CreateAd();
        interstitialAd.OnAdLoaded += InterstitialAd_OnAdLoaded;
        interstitialAd.Load();
	}

    private static void InterstitialAd_OnAdLoaded(object? sender, EventArgs e)
    {
        if (sender is IInterstitialAd interstitialAd)
        {
            interstitialAd.Show();
        }
    }
}

