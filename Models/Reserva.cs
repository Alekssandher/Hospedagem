namespace Hospedagem.Models
{
    public class Reserva
    {
        private static int _contador = 0;

        public int Id { get; private set; }
        public List<Pessoa>? Hospedes { get; set; }
        public Suite? Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            Id = ++_contador;
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite == null)
            {
                throw new InvalidOperationException("A suíte precisa ser cadastrada antes de adicionar hóspedes.");
            }

            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A Quantidade de Hóspedes é maior que a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            if (Hospedes == null)
            {   
                throw new Exception("Não Há Hospedes.");
            }
            return Hospedes.Count;
        }

        public double CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*

            if (Suite == null)
            {
                throw new Exception("Não Há Suítes");
            }
            double valor = Suite.ValorDiaria * DiasReservados;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valor -=  valor * 0.1;
            }

            return valor;
        }
    }
}