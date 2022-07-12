using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISEVID.Models
{
    public class Numeral
    {   
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Numero { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [ForeignKey("LiteralId")]
        public Guid LiteralId { get; set; }

        public virtual Literal Literal { get; set; }


    }
}