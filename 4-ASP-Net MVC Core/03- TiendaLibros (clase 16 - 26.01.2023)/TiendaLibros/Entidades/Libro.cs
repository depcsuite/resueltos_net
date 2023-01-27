using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace TiendaLibros.Entidades
{
    public class Libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        public string ISBN { get; set; }

        public int? Ranking { get; set; }

        [Required]
        public string Titulo { get; set; }

        public string Autor { get; set; }

        [DataType(DataType.Currency)]
        [Range(1, 10000)]
        public decimal Precio { get; set; }

        public string PortadaUri { get; set; }

        public LibroDetalle Detalles { get; set; }
    }
}
