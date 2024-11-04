namespace MauiAppHotel.Views;

public partial class SobreHotel : ContentPage
{
    public SobreHotel()
    {
        InitializeComponent();
    }
    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}