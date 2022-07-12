using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISEVID.Models
{
    public class Articulo
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }        
        [Required]
        [MaxLength(10)]
        public string Numero { get; set; }
        [Required]
        public string Descripcion { get; set; }

        [Required]
        [ForeignKey("CondicionId")]
        public Guid CondicionId { get; set; }

        public virtual Condicion Condicion { get; set; }
        
        public virtual ICollection<Literal> Literales {get;set;}
    }
}