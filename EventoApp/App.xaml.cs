using Microsoft.Extensions.DependencyInjection;

namespace EventoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Modifique esta linha para habilitar a barra de navegação superior
            MainPage = new NavigationPage(new MainPage());
        }
    }
}