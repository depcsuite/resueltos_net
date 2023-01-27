using System.ComponentModel.DataAnnotations;

namespace TiendaLibros.Dtos
{
    public class LibroDetalleDto
    {

        [MaxLength(50)]
        public string Genero { get; set; }

        [MaxLength(200)]
        public string Resumen { get; set; }


        [Display(Name = "Dia de publicación")]
        [DataType(DataType.Date)]
        public DateTime? FechaPublicacion { get; set; }

    }
}