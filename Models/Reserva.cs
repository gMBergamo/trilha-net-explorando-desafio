namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
            Hospedes = Suite.Capacidade >= hospedes.Count ? hospedes : throw new Exception($"Capacidade menor que o número de hóspedes, capacidade: {Suite.Capacidade}, hóspedes: {hospedes.Count}.");
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count;
        }

        public string ObterHospedesCadastrados()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return string.Join(", ", Hospedes.Select(h => h.Nome));
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            return DiasReservados >= 10 ? valor - (valor * 0.1m) : valor;
        }
    }
}