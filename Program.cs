using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new();

Pessoa p1 = new(nome: "Giovanni Bergamo");
Pessoa p2 = new(nome: "Ana Carolina");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new(tipoSuite: "Premium", capacidade: 2, valorDiaria: 150);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Estão hospedados: {reserva.ObterHospedesCadastrados()}");
Console.WriteLine($"Diarias: {reserva.DiasReservados}");
Console.WriteLine($"Tipo da Suíte: {reserva.Suite.TipoSuite}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");