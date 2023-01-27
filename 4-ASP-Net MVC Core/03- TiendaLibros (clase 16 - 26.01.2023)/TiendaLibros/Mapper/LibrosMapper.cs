using TiendaLibros.Dtos;
using TiendaLibros.Entidades;
using TiendaLibros.Models;

namespace TiendaLibros.Mapper
{
    public class LibrosMapper
    {
        public static List<LibroDto> Map(List<Libro> libros)
        {
            List<LibroDto> librosDto = new List<LibroDto>();

            if (libros == null) return null;

            foreach (var lb in libros)
            {
                var libro = new LibroDto()
                {
                    Autor = lb.Autor,
                    ISBN = lb.ISBN,
                    PortadaLink = lb.PortadaUri,
                    Precio = lb.Precio,
                    Ranking = lb.Ranking,
                    Titulo = lb.Titulo,

                };
                if (lb.Detalles != null)
                {
                    libro.Detalles = new LibroDetalleDto()
                    {
                        FechaPublicacion = lb.Detalles.FechaPublicacion,
                        Genero = lb.Detalles.Genero.ToString(),
                        Resumen = lb.Detalles.Resumen
                    };
                }

                librosDto.Add(libro);
            }
            
            return librosDto;

        }

        internal static LibroDto MapADto(Libro libro)
        {
            var libroDto = new LibroDto()
            {
                Autor = libro.Autor,
                ISBN = libro.ISBN,
                PortadaLink = libro.PortadaUri,
                Precio = libro.Precio,
                Ranking = libro.Ranking,
                Titulo = libro.Titulo,

            };
            if (libro.Detalles != null)
            {
                libroDto.Detalles = new LibroDetalleDto()
                {
                    FechaPublicacion = libro.Detalles.FechaPublicacion,
                    Genero = libro.Detalles.Genero.ToString(),
                    Resumen = libro.Detalles.Resumen
                };
            }

            return libroDto;
        }
    }
}