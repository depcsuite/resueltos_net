using System.ComponentModel.DataAnnotations;

namespace TiendaLibros.Models
{
    public class LibroDto
    {
        public string? ISBN { get; set; }

        public int? Ranking { get; set; }

        [Required]
        public string Titulo { get; set; }

        public string Autor { get; set; }

        [DataType(DataType.Currency)]
        [Range(1, 10000)]
        public decimal Precio { get; set; }

        public string PortadaLink { get; set; }

        public LibrosDetalleDto Detalles { get; set; }
    }
}
