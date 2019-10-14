using Microsoft.EntityFrameworkCore;
using modulo2.DAL.Domain;

namespace modulo2.DAL.Contexts
{
    public class Modulo2Context : DbContext
    {
        public Modulo2Context(DbContextOptions<Modulo2Context> options): base(options){}
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}