using SistemaReservaSalas.Modelos;

Console.WriteLine("CONFIGURAÇÃO DE RESERVAS");

Console.Write("Data mínima (dd/MM/yyyy): ");
var dataMin = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", null);

Console.Write("Data máxima (dd/MM/yyyy): ");
var dataMax = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", null);

Console.Write("Hora mínima (HH:mm): ");
var horaMin = TimeSpan.Parse(Console.ReadLine()!);

Console.Write("Hora máxima (HH:mm): ");
var horaMax = TimeSpan.Parse(Console.ReadLine()!);

ConfiguracaoReserva configuracao;
try
{
    configuracao = new ConfiguracaoReserva(dataMin, dataMax, horaMin, horaMax);
}
catch (Exception ex)
{
    Console.WriteLine($"Erro na configuração: {ex.Message}");
    return;
}

Console.WriteLine("\nCADASTRO DE RESERVA");

var reserva = new Reserva(configuracao);

Console.Write("Data da reserva (dd/MM/yyyy): ");
reserva.RegistrarData(DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", null));

Console.Write("Hora da reserva (HH:mm): ");
reserva.RegistrarHora(TimeSpan.Parse(Console.ReadLine()!));

Console.Write("Descrição da sala: ");
reserva.RegistrarDescricao(Console.ReadLine()!);

Console.Write("Capacidade: ");
reserva.RegistrarCapacidade(int.Parse(Console.ReadLine()!));

var erros = reserva.ValidarReserva();

if (erros.Count > 0)
{
    Console.WriteLine("\nErros encontrados:");
    foreach (var erro in erros)
        Console.WriteLine("- " + erro);
}
else
{
    Console.WriteLine("\nReserva registrada com sucesso!");
    Console.WriteLine(reserva);
}
