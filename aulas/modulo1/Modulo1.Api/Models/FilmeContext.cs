using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Modulo1.Api.Models
{
    public partial class FilmeContext : DbContext
    {
        public FilmeContext()
        {
        }

        public FilmeContext(DbContextOptions<FilmeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Filme> Filmes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // if (!optionsBuilder.IsConfigured)
            // {
            //     optionsBuilder.UseSqlServer("Data Source=tcp:20487.database.windows.net,1433;Initial Catalog=modulo1pipsdb;User Id=pilao@20487.database.windows.net;Password=!QAZ.2wsx.;");
            // }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Filme>(entity =>
            {
                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
