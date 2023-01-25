using TiendaLibros.Data;
using TiendaLibros.Models;

namespace TiendaLibros.Controllers
{
    public class LibrosMapper
    {
        public static List<LibroDto> Map(List<Libro> libros)
        {
            List<LibroDto> librosDto = new List<LibroDto>();

            if (libros == null) return null;

            foreach (var l in libros)
            {
                var libro = new LibroDto()
                {
                    Autor = l.Autor,
                    ISBN = l.Id,
                    PortadaLink = l.PortadaUri,
                    Precio = l.Precio,
                    Ranking = l.Ranking,
                    Titulo = l.Titulo,
                   
                };
                if (libro.Detalles != null)
                {
                    libro.Detalles = new LibrosDetalleDto()
                    {
                        FechaPublicacion = l.Detalles.FechaPublicacion,
                        Genero = l.Detalles.Genero.ToString(),
                        Resumen = l.Detalles.Resumen
                    };
                }
            }

            return librosDto;
           
        }
    }
}