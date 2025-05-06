using System;

namespace SistemaReservaSalas.Modelos
{
    public class Reserva
    {
        public DateTime Data { get; private set; }
        public TimeSpan Hora { get; private set; }
        public string DescricaoDaSala { get; private set; } = string.Empty;
        public int Capacidade { get; private set; }

        private readonly ConfiguracaoReserva _configuracao;

        public Reserva(ConfiguracaoReserva configuracao)
        {
            _configuracao = configuracao;
        }

        public void RegistrarData(DateTime data) => Data = data;
        public void RegistrarHora(TimeSpan hora) => Hora = hora;
        public void RegistrarDescricao(string descricao) => DescricaoDaSala = descricao;
        public void RegistrarCapacidade(int capacidade) => Capacidade = capacidade;

        public List<string> ValidarReserva()
        {
            List<string> erros = new();

            if (Data < _configuracao.DataMinima || Data > _configuracao.DataMaxima)
                erros.Add("Data fora do intervalo permitido.");

            if (Hora < _configuracao.HoraMinima || Hora > _configuracao.HoraMaxima)
                erros.Add("Hora fora do intervalo permitido.");

            if (Capacidade <= 0 || Capacidade >= 40)
                erros.Add("Capacidade deve estar entre 1 e 39.");

            return erros;
        }

        public override string ToString()
        {
            return $"Reserva para sala '{DescricaoDaSala}' em {Data:dd/MM/yyyy} às {Hora:hh\\:mm} para {Capacidade} alunos.";
        }
    }
}
