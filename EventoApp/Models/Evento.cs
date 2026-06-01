    namespace EventoApp
    {
        public class Evento
        {
            public string Nome { get; set; }
            public string Local { get; set; }
            public DateTime DataInício { get; set; }
            public DateTime DataTérmino { get; set; }
            public int NumeroParticipantes { get; set; }
            public decimal CustoPorParticipante { get; set; }

            
            public int DuracaoEmDias
            {
                get
                {
                    if (DataTérmino < DataInício)
                        return 0;

                    
                    return (DataTérmino - DataInício).Days + 1;
                }
            }

            
            public decimal CustoTotal
            {
                get
                {
                    return NumeroParticipantes * CustoPorParticipante;
                }
            }
        }
    }

