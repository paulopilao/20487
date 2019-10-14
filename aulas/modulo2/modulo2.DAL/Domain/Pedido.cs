using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace modulo2.DAL.Domain
{
    public class Pedido{
        public int Id { get; set; }
        public Decimal ValorTotal { get; set; }
        public Cliente Cliente { get; set; }
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
    }
}