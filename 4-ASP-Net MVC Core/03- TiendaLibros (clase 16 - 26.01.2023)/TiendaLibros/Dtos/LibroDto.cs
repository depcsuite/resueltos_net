using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TiendaLibros.Dtos
{
    public class LibroDto
    {
        public string? ISBN { get; set; }

        public int? Ranking { get; set; }

        [Display(Name = "Libro Title")]
        [Required]
        public string Titulo { get; set; }

        public string Autor { get; set; }

        [DataType(DataType.Currency)]
        [Range(1, 10000)]
        public decimal Precio { get; set; }

        public string PortadaLink { get; set; }

        public LibroDetalleDto Detalles { get; set; }
    }
}
