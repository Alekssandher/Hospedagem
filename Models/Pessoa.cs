using System.Data.Common;

namespace Hospedagem.Models;

public class Pessoa
{
    private static int _contador = 0;
    public int Id { get; private set; }
    public string Nome { get; set; }
    public string? Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    
    public Pessoa(string nome, string? sobrenome = null)
    {
        Id = ++_contador;
        Nome = nome;
        Sobrenome = sobrenome;
    }
}