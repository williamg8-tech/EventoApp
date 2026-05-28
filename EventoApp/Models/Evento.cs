namespace EventoApp
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInício { get; set; } = DateTime.Today;
        public DateTime DataTérmino { get; set; } = DateTime.Today.AddDays(1);
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Propriedade calculada usando TimeSpan para obter a duração em dias
        public int DuracaoEmDias
        {
            get
            {
                TimeSpan diferenca = DataTérmino - DataInício;
                // Retorna pelo menos 1 dia caso as datas sejam iguais, ou a quantidade real de dias
                return diferenca.Days < 0 ? 0 : (diferenca.Days == 0 ? 1 : diferenca.Days);
            }
        }

        // Propriedade calculada para o custo total
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}