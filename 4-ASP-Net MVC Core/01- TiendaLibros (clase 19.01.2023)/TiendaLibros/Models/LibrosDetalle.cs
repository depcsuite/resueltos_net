using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TiendaLibros.Models
{
    public class LibrosDetalle
    {
    
        [MaxLength(50)]
        public string Genero { get; set; }

        [MaxLength(400)]
        public string Resumen { get; set; }

    
        [Display(Name = "Dia de publicación")]
        [DataType(DataType.Date)]
        public DateTime FechaPublicacion { get; set; }

    }
}