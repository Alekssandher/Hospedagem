
using Hospedagem.Models;

namespace Hospedagem.Services
{
    public static class ReservaService
    {
        public static void ReservarSuite(ref List<Suite> suites, ref List<Pessoa> hospedes, ref List<Reserva> reservas)
        {
            Console.WriteLine("A Reserva Será Para Quantas Pessoas?");
            int reservasC = Convert.ToInt32(Console.ReadLine());

            var suitesDisponiveis = suites.FindAll(s => s.Capacidade <= reservasC && !s.Ocupada);

            if (suitesDisponiveis == null)
            {
                Console.WriteLine("Não Há Suites Disponíveis.");
                return;
            }

            Console.WriteLine("As Seguintes Suites Estão Disponíveis:");
            foreach (Suite s in suites)
            {
                Console.WriteLine($"Id: {s.Id}");
                Console.WriteLine($"Tipo: {s.TipoSuite}");
                Console.WriteLine($"Capacidade: {s.Capacidade}");
                Console.WriteLine($"Valor da Diária: {s.ValorDiaria}");
                Console.WriteLine("-----------------------------");
            }
            var suite = PegarSuite(ref suites);

            Console.WriteLine("Os Seguintes Hóspedes Estão Cadastrados:");
            foreach (Pessoa s in hospedes)
            {
                Console.WriteLine($"Id: {s.Id}");
                Console.WriteLine($"Nome: {s.NomeCompleto}");
                Console.WriteLine("-----------------------------");
            }

            var hospedados = PegarHospedados(ref hospedes, reservasC);

            Console.WriteLine("Por Quantos Dias Deseja Reservar o Quarto?");
            int diasReservados = Convert.ToInt32(Console.ReadLine());

            Reserva reserva = new(diasReservados);

            try
            {
                reserva.CadastrarSuite(suite);
                reserva.CadastrarHospedes(hospedados);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            reservas.Add(reserva);
            Console.WriteLine("Quarto Reservado Com Sucesso!");

            return;

        }

        public static void MostrarReservas(ref List<Reserva> reservas)
        {
            if (reservas.Count == 0)
            {
                Console.WriteLine("Não Há Reservas!");
                return;
            }
            
            Console.WriteLine("Eis as Reservas:");

            foreach (Reserva r in reservas)
            {
                Console.WriteLine($"Id: {r.Id}");
                Console.WriteLine($"Dias da Reserva: {r.DiasReservados}");
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("Precione Qualquer Tecla Para Continuar");
            Console.ReadKey();

            return;
        }

        private static List<Pessoa> PegarHospedados(ref List<Pessoa> hospedes, int reservas)
        {
            var h = new List<Pessoa>();

            for (int i = 0; i < reservas; i++)
            {
                Console.WriteLine($"Digite o ID do Hóspede {i + 1}:");
                int id = Convert.ToInt32(Console.ReadLine());

                var encontrado = hospedes.Find(o => o.Id == id);

                if (encontrado != null)
                {
                    h.Add(encontrado);
                }
                else
                {
                    Console.WriteLine("Hóspede não encontrado. Tente novamente.");
                    i--;
                }
            }
            Console.Clear();
            return h;
        }

        private static Suite PegarSuite(ref List<Suite> suites)
        {
            Console.WriteLine("Digite o ID da Suíte Que Deseja Reservar:");
            int idSuite = Convert.ToInt32(Console.ReadLine());

            var suite = suites.Find(s => s.Id == idSuite);

            if (suite == null)
            {
                Console.WriteLine($"Suite Não Encontrada com o ID {idSuite}");
                Console.WriteLine("Precione Qualquer Tecla Para Continuar");
                Console.ReadKey();
                Console.Clear();
                return PegarSuite(ref suites);
            }

            return suite;
        }
    }
}