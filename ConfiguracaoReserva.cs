namespace SistemaReservaSalas.Modelos
{
    public class ConfiguracaoReserva
    {
        public DateTime DataMinima { get; private set; }
        public DateTime DataMaxima { get; private set; }
        public TimeSpan HoraMinima { get; private set; }
        public TimeSpan HoraMaxima { get; private set; }

        public ConfiguracaoReserva(DateTime dataMinima, DateTime dataMaxima, TimeSpan horaMinima, TimeSpan horaMaxima)
        {
            DateTime hoje = DateTime.Today;

            if (dataMinima < hoje)
                throw new ArgumentException("A data mínima não pode ser anterior à data de hoje.");

            if (dataMaxima < hoje)
                throw new ArgumentException("A data máxima não pode ser anterior à data de hoje.");

            if (dataMinima > dataMaxima)
                throw new ArgumentException("Data mínima deve ser menor que a data máxima.");

            if (horaMinima > horaMaxima)
                throw new ArgumentException("Hora mínima deve ser menor que a hora máxima.");

            DataMinima = dataMinima;
            DataMaxima = dataMaxima;
            HoraMinima = horaMinima;
            HoraMaxima = horaMaxima;
        }
    }
}
