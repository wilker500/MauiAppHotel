namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}
    // Aqui voc� adiciona o m�todo para o clique do bot�o
    private async void OnSobreButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}
