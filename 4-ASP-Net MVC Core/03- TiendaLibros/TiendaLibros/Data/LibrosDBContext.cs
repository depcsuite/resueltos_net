using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace TiendaLibros.Data
{
    public class LibrosDBContext : DbContext
    {
        public LibrosDBContext(DbContextOptions<LibrosDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>().ToTable("Libros");
            modelBuilder.Entity<LibrosDetalle>().ToTable("LibrosDetalle");
        }

        public DbSet<Libro> Libros { get; set; }  //Nombre variable en plural.
        public DbSet<LibrosDetalle> LibrosDetalles { get; set; }
    }
}
    