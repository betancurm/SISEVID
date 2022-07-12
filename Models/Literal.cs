using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISEVID.Models
{
    public class Literal
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Letra { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [ForeignKey("ArticuloId")]
        public Guid ArticuloId { get; set; }
        public virtual Articulo Articulo { get; set; }

        public virtual ICollection<Numeral> Numerales { get; set; }
    }
}