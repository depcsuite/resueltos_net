using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaLibros.Entidades
{
    public class LibroDetalle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        public int Genero { get; set; }

        public string Resumen { get; set; }

        public string ResumenLink { get; set; }

        public string Editorial { get; set; }

        public int Edicion { get; set; }

        public int Formato { get; set; }  //Si es tapa dura, blanda, eBook.

        [Display(Name = "Dia de publicación")]
        [DataType(DataType.Date)]
        public DateTime FechaPublicacion { get; set; }

    }
}