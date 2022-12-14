using DesafioHospedagem.Models;


List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Elvis", "Presley");
Pessoa p2 = new Pessoa("Michael", "Jackson");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite("Premium", 5, 20);

Reserva reserva = new Reserva(12);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");