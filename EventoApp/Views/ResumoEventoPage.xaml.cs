using EventoApp;

namespace EventoApp
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento eventoSelecionado)
        {
            InitializeComponent();
            BindingContext = eventoSelecionado;
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}