using System.ComponentModel.DataAnnotations;

namespace TiendaLibros.Models
{
    public class LibrosDetalleDto
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