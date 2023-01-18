using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TiendaLibros.Models
{
    public class Detalle
    {
        public decimal Precio { get; set; }
        public string Genero { get; set; }

        [DataType(DataType.Currency)]
        [Range(1, 10000)]
        public string Resumen { get; set; }

        public string PortadaUri { get; set; }

        [Display(Name = "Dia de publicación")]
        [DataType(DataType.Date)]
        public DateTime FechaPublicacion { get; set; }

    }
}