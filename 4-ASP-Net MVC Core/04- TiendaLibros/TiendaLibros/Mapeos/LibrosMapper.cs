using TiendaLibros.Dtos;
using TiendaLibros.Entidades;

namespace TiendaLibros.Mapeos
{
    internal class LibrosMapper
    {
        internal static Libro Mapear(LibroDto libroDto)
        {
            var libro = new Libro()
            {
                Autor = libroDto.Autor,
                ISBN = libroDto.ISBN,
                PortadaUri = libroDto.PortadaLink,
                Ranking = libroDto.Ranking,
                Precio = libroDto.Precio,
                Titulo = libroDto.Titulo,
                Detalles = new LibroDetalle()
                {
                    FechaPublicacion = (DateTime)libroDto.Detalles.FechaPublicacion,
                    Genero = ConvertToGeneroEnum(libroDto.Detalles.Genero),
                    Resumen = libroDto.Detalles.Resumen
                }
            };

            return libro;
        }

        private static int ConvertToGeneroEnum(string genero)
        {
            switch (genero)
            {
                case "Novela":
                    return Convert.ToInt32(GeneroEnum.Novela);
                case "CienciaFiccion":
                    return Convert.ToInt32(GeneroEnum.CienciaFiccion);
                case "Escolares":
                    return Convert.ToInt32(GeneroEnum.Escolares);

                default: return -1;  break;
            }
            
        }

        internal static LibroDto MapearADto(Libro libro)
        {
            var dto = new LibroDto()
            {
                Autor = libro.Autor,
                ISBN = libro.ISBN,
                PortadaLink = libro.PortadaUri,
                Ranking = libro.Ranking,
                Precio = libro.Precio,
                Titulo = libro.Titulo,
                Detalles = new LibroDetalleDto()
                {
                    FechaPublicacion = libro.Detalles.FechaPublicacion,
                    Genero = libro.Detalles.Genero.ToString(),
                    Resumen = libro.Detalles.Resumen
                }
            };

            return dto;
        }

        internal static List<LibroDto> MapearADto(List<Libro> libros)
        {
            var librosDto = new List<LibroDto>();

            foreach (var lb in libros)
            {
                var dto = new LibroDto()
                {
                    Autor = lb.Autor,
                    ISBN = lb.ISBN,
                    PortadaLink = lb.PortadaUri,
                    Ranking = lb.Ranking,
                    Precio = lb.Precio,
                    Titulo = lb.Titulo,
                    Detalles = new LibroDetalleDto()
                    {
                        FechaPublicacion = lb.Detalles != null ? lb.Detalles.FechaPublicacion : null,
                        Genero = lb.Detalles != null ? lb.Detalles.Genero.ToString() : null,
                        Resumen = lb.Detalles != null ? lb.Detalles.Resumen : string.Empty
                    }
                };

                librosDto.Add(dto);
            }

            return librosDto;
        }
    }
}