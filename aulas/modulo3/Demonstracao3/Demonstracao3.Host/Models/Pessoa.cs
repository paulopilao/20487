using System;
namespace Demonstracao3.Models
{
    public class Pessoa{
        public Pessoa(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string  Cpf { get; set; }
    }
}