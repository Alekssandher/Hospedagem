using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hospedagem.Models;

namespace Hospedagem.Services
{
    public static class HospedeService
    {
        
        public static void CadastrarHospede(ref List<Pessoa> pessoas)
        {
            Console.WriteLine("Digite a Quantidade de Hóspedes a Cadastrar:");
            int hospedesC = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < hospedesC; i++)
            {
                pessoas.Add(PegarHospedes(i));
            }

            


        }
        private static Pessoa PegarHospedes(int i)
        {
            Console.Clear();
            Console.WriteLine($"Digite o Nome do Hóspede {i + 1}:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite o Sobrenome do Hóspede:");
            var sobrenome = Console.ReadLine();

            if (nome == null)
            {
                throw new Exception();
            }

            return new Pessoa(nome, sobrenome);
        }
    }
}