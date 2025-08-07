
using Hospedagem.Models;

namespace Hospedagem.Services
{
    public class SuiteService
    {
        public static void CadastrarSuite(ref List<Suite> suites)
        {
            Console.WriteLine("Quantas Suites Deseja Cadastrar?");
            int suitesC = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < suitesC; i++)
            {
                suites.Add(CriarSuite());
            }
        }

        private static Suite CriarSuite()
        {
            Console.WriteLine("Digite o Tipo de Suite (simples/luxo/premium):");
            
            if (!Enum.TryParse<TipoSuite>(Console.ReadLine(), ignoreCase: true, out var tipoSuite))
            {
                Console.WriteLine("Tipo inválido.");
                return CriarSuite();
            }

            Console.WriteLine("Digite a Capacidade da Suite:");
            int capacidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Valor da Diária:");
            double valorDiaria = Convert.ToDouble(Console.ReadLine());

            return new Suite(tipoSuite, capacidade, valorDiaria);
        }
    }
}