
namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState) //sobrescrevendo o método
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;  //largura de janela
            window.Height = 600; //altura de janela
            return window;
        }
    }
}
