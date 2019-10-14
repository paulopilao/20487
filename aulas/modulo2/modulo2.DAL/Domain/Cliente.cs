using System.Collections.Generic;

namespace modulo2.DAL.Domain
{
    public class Cliente
    {
        public Cliente(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}