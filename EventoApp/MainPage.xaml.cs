namespace EventoApp
{
    public partial class MainPage : ContentPage
    {
        public Evento NovoEvento { get; set; }

        public MainPage()
        {
            InitializeComponent();

            NovoEvento = new Evento
            {
                NumeroParticipantes = 0,
                DataInício = DateTime.Today,
                DataTérmino = DateTime.Today
            };

            BindingContext = NovoEvento;
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            
            if (NovoEvento.DataTérmino < NovoEvento.DataInício)
            {
                await DisplayAlert("Erro nas Datas", "A data de término não pode ser anterior à data de início.", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(NovoEvento.Nome))
            {
                await DisplayAlert("Campo Obrigatório", "Por favor, digite o nome do evento.", "OK");
                return;
            }

            
            await Navigation.PushAsync(new ResumoEventoPage(NovoEvento));
        }
    }
}
