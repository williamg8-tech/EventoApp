namespace EventoApp
{
    public partial class MainPage : ContentPage
    {
        public Evento NovoEvento { get; set; }

        public MainPage()
        {
            InitializeComponent();

            // Instancia o objeto e define como o contexto de dados da página
            NovoEvento = new Evento { NumeroParticipantes = 0 };
            BindingContext = NovoEvento;
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Validação básica de consistência de datas antes de avançar
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

            // Navega para a página de resumo, passando o objeto preenchido no construtor
            await Navigation.PushAsync(new ResumoEventoPage(NovoEvento));
        }
    }
}
