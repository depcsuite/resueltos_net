using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace TiendaLibros.Data
{
    public class LibrosDetalle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [MaxLength(50)]
        public GeneroEnum Genero { get; set; }

        [MaxLength(200)]
        public string Resumen { get; set; }

        public string ResumenLink { get; set; }

        public string Editorial { get; set; }

        public int Edicion { get; set; }

        public FormatoEnum Formato { get; set; }  //Si es tapa dura, blanda, eBook.

        [Display(Name = "Dia de publicación")]
        [DataType(DataType.Date)]
        public DateTime FechaPublicacion { get; set; }

    }
}