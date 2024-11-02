namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}
    // Aqui você adiciona o método para o clique do botão
    private async void OnSobreButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}
