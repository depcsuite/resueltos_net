using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using TiendaLibros.Entidades;

namespace TiendaLibros.Data
{
    public class LibrosDBContext : DbContext
    {
        public LibrosDBContext(DbContextOptions<LibrosDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Se usa en el caso de que la entidad tenga nombre diferente a la tabla.
            //Se deja como ejemplo
            //modelBuilder.Entity<Libro>().ToTable("Libro");
            //modelBuilder.Entity<LibrosDetalle>().ToTable("LibroDetalle");

            modelBuilder.Entity<Libro>()
                        .HasOne(p => p.Detalles);
        }
                        

        public DbSet<Libro> Libros { get; set; }  //Nombre variable en plural.
        public DbSet<LibroDetalle> LibroDetalles { get; set; }


    }
}
    