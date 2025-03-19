namespace TestInterstitialIOS;

public partial class ModalPage : ContentPage
{
    public ModalPage()
    {
        InitializeComponent();
    }

    private void ShowInterstitialAd(object sender, EventArgs e)
    {
        MainPage.LoadAndShowInterstitial();
    }

    private async void CloseModal(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }


}
