using Microsoft.EntityFrameworkCore;
using System.Globalization;
using TiendaLibros.Entidades;

namespace TiendaLibros.Data
{
    public class LibrosDBContext : DbContext
    {
        public LibrosDBContext(DbContextOptions<LibrosDBContext> options) : base(options)
        {
        }

        public DbSet<Libro> Libros { get; set; }  //Nombre variable en plural.
        public DbSet<LibroDetalle> LibroDetalles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Se usa en el caso de que la entidad tenga nombre diferente a la tabla.
            //Se deja como ejemplo
            //modelBuilder.Entity<Libro>().ToTable("Libro");
            //modelBuilder.Entity<LibrosDetalle>().ToTable("LibroDetalle");

            modelBuilder.Entity<LibroDetalle>()
               .HasData(
                        new LibroDetalle()
                        {
                            Id = 1,
                            FechaPublicacion = DateTime.ParseExact("10-02-1990", "MM-dd-yyyy", CultureInfo.CurrentCulture),
                            Genero = Convert.ToInt32(GeneroEnum.Novela),
                            Resumen = "Es de huido abeja lentejas de la pero carcajadas me hule luna comida se para la pero llenando"
                        },
                        new LibroDetalle()
                        {
                            Id = 2,
                            FechaPublicacion = DateTime.ParseExact("10-02-1900", "MM-dd-yyyy", CultureInfo.CurrentCulture),
                            Genero = Convert.ToInt32(GeneroEnum.Novela),
                            Resumen = "Menedékünk ölel kicifrázva ríjjátok rázza gyalázat míg ríjjátok égjen nem és meg mint de bukjatok "
                        },
                        new LibroDetalle()
                        {
                            Id = 3,
                            FechaPublicacion = DateTime.ParseExact("10-02-2020", "MM-dd-yyyy", CultureInfo.CurrentCulture),
                            Genero = Convert.ToInt32(GeneroEnum.Novela),
                            Resumen = "Éclairs fileur sillage d'europe plein qu'on la montait fleurs atroce est-ce bleu courais"
                        },
                        new LibroDetalle()
                        {
                            Id = 4,
                            FechaPublicacion = DateTime.ParseExact("10-02-1985", "MM-dd-yyyy", CultureInfo.CurrentCulture),
                            Genero = Convert.ToInt32(GeneroEnum.Novela),
                            Resumen = "Clita magna rebum euismod aliquam eos aliquip ea nostrud kasd duis justo labore ea dolore "
                        },
                        new LibroDetalle()
                        {
                            Id = 5,
                            FechaPublicacion = DateTime.ParseExact("10-02-2022", "MM-dd-yyyy", CultureInfo.CurrentCulture),
                            Genero = Convert.ToInt32(GeneroEnum.Novela),
                            Resumen = "Neu es schöne faßt dunst einst froher trüben mein klage tränen zu zu die und folgenden der "
                        }
                );


            //Add initial data --> Seeding
            modelBuilder.Entity<Libro>()
               .HasData(
                   new Libro()
                   {
                       Id = -1,
                       Ranking = 9,
                       ISBN = "100",
                       Titulo = "100 años de Soledad",
                       Autor = "Garcia Marquez",
                       Precio = 2300,
                       PortadaUri = "100.png",
                       DetallesId = 1
                   },
                   new Libro()
                   {
                        Id = -2,
                        Ranking = 9,
                        ISBN = "101",
                        Titulo = "La metaforfosis",
                        Autor = "Kafka",
                        Precio = 3300,
                        PortadaUri = "101.png",
                        DetallesId = 2
        
                    },
                    new Libro()
                    {
                        Id = -3,
                        Ranking = 3,
                        ISBN = "102",
                        Titulo = "Como ganar tu primer Millon",
                        Autor = "Mario Quintero",
                        Precio = 2800,
                        PortadaUri = "102.png",
                        DetallesId = 3
                    },
                    new Libro()
                    {
                        Id = -4,
                        Ranking = 8,
                        ISBN = "103",
                        Titulo = "La guerra de la triple alianza",
                        Autor = "Garcia Belsunse ",
                        Precio = 5300,
                        PortadaUri = "103.png",
                        DetallesId = 4
                    },
                    new Libro()
                    {
                        Id = -5,
                        Ranking = 2,
                        ISBN = "104",
                        Titulo = "Predicciones 2023",
                        Autor = "Ludovica Skuir",
                        Precio = 1000,
                        PortadaUri = "104.png",
                        DetallesId = 5
         
                    }
               );

            //Write Fluent API configurations here

            //Property Configurations
            modelBuilder.Entity<Libro>()
                    .Property(s => s.Id)
                    .HasColumnName("Id")
                    .IsRequired()
                    .UseIdentityColumn();

            modelBuilder.Entity<Libro>()
                   .Property(s => s.ISBN)
                   .HasColumnName("ISBN")
                   .HasDefaultValue("")
                   .IsRequired();

            modelBuilder.Entity<Libro>()
                   .Property(s => s.PortadaUri)
                   .HasColumnName("PortadaUri")
                   .HasDefaultValue("");
        
            modelBuilder.Entity<Libro>()
                  .Property(s => s.Titulo)
                  .HasColumnName("Titulo")
                  .HasMaxLength(50)
                  .HasDefaultValue("")
                  .IsRequired();

            modelBuilder.Entity<Libro>()
                 .Property(s => s.Precio)
                 .HasColumnName("Precio")
                 .HasDefaultValue(0)
                 .IsRequired();

            modelBuilder.Entity<Libro>()
                .Property(s => s.Autor)
                .HasColumnName("Autor")
                .HasMaxLength(50)
                .HasDefaultValue(0)
                .IsRequired();

            modelBuilder.Entity<LibroDetalle>()
               .Property(s => s.Id)
               .HasColumnName("Id")
               .HasMaxLength(50)
               .IsRequired()
               .UseIdentityColumn();

            modelBuilder.Entity<LibroDetalle>()
              .Property(s => s.FechaPublicacion)
              .HasColumnName("FechaPublicacion")
              .HasDefaultValue(DateTime.MinValue);


            modelBuilder.Entity<LibroDetalle>()
               .Property(s => s.Edicion)
               .HasColumnName("Edicion")
               .HasDefaultValue(0);

            modelBuilder.Entity<LibroDetalle>()
               .Property(s => s.Editorial)
               .HasColumnName("Editorial")
               .HasDefaultValue("");

            modelBuilder.Entity<LibroDetalle>()
                .Property(s => s.Resumen)
                .HasColumnName("Resumen")
                .HasMaxLength(500)
                .HasDefaultValue("");

            modelBuilder.Entity<LibroDetalle>()
                .Property(s => s.Genero)
                .HasColumnName("Genero")
                .HasMaxLength(20);
                

            modelBuilder.Entity<LibroDetalle>()
                .Property(s => s.ResumenLink)
                .HasColumnName("ResumenLink")
                .HasMaxLength(100)
                .HasDefaultValue("");

            modelBuilder.Entity<LibroDetalle>()
                .Property(s => s.Formato)
                .HasColumnName("Formato")
                .HasDefaultValue(0);


        }

    }
}
