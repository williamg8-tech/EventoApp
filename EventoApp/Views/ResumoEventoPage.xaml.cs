

namespace EventoApp
{
    public partial class ResumoEventoPage : ContentPage
    {
        
        public ResumoEventoPage(Evento eventoCadastrado)
        {
            InitializeComponent();

            
            BindingContext = eventoCadastrado;
        }

        
        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            
            await Navigation.PopAsync();
        }
    }
}