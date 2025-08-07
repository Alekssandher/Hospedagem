namespace Hospedagem.Models
{
    public class Suite
    {
        private static int _contador = 0;

        public Suite(TipoSuite tipoSuite, int capacidade, double valorDiaria)
        {
            Id = ++_contador;
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public TipoSuite TipoSuite { get; set; }
        public int Id { get; private set; }
        public int Capacidade { get; set; }
        public double ValorDiaria { get; set; }
        public bool Ocupada { get; set; } = false;
    }

    public enum TipoSuite
    {
        Simples,
        Luxo,
        Premium
        
    }
}