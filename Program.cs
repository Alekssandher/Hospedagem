using System.Text;
using Hospedagem.Models;
using Hospedagem.Services;

namespace Hospedagem;

public partial class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        bool exibirMenu = true;

        // Cria os modelos de hóspedes e cadastra na lista de hóspedes
        List<Pessoa> hospedes = [];
        List<Suite> suites = [];
        List<Reserva> reservas = [];
        
        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar Hóspede");
            Console.WriteLine("2 - Cadastrar Suíte");
            Console.WriteLine("3 - Reservar Quarto");
            Console.WriteLine("4 - Listar Reservas");
            Console.WriteLine("5 - Fechar Programa");

            switch (Console.ReadLine())
            {
                case "1":
                    HospedeService.CadastrarHospede(ref hospedes);

                    Console.Clear();
                    Console.WriteLine("Cadastro Feito Com Sucesso!\nPrecione qualquer tecla para continuar.");
                    Console.ReadKey();

                    break;
                case "2":
                    SuiteService.CadastrarSuite(ref suites);
                    break;
                case "3":
                    ReservaService.ReservarSuite(ref suites, ref hospedes, ref reservas);
                    break;
                case "4":
                    try
                    {
                        ReservaService.MostrarReservas(ref reservas);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                    break;
                case "5":
                    Console.WriteLine("Terminado");
                    return;


            }
        }
    }

    
}