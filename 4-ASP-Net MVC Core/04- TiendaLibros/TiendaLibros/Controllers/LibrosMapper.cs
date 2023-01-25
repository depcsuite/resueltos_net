using TiendaLibros.Models;

namespace TiendaLibros.Controllers
{
    internal class LibrosMapper
    {
        internal static Libro Mapear(LibroDto libroDto)
        {
            throw new NotImplementedException();
        }

        internal static LibroDto MapearADto(Libro libro)
        {
            var dto = new LibroDto()
            {
                Autor = libro.Autor,
                ISBN = libro.ISBN,
                PortadaLink = libro.PortadaUri,
                Ranking = libro.Ranking,
                Precio = libro.Precio ,
                Titulo = libro.Titulo,
                Detalles = new LibrosDetalleDto()
                {
                    FechaPublicacion = libro.Detalles.FechaPublicacion,
                    Genero = libro.Detalles.Genero.ToString(),
                    Resumen = libro.Detalles.Resumen
                }
            };

            return dto;
        }

        internal static object MapearADto(List<Libro> libros)
        {
            throw new NotImplementedException();
        }
    }
}