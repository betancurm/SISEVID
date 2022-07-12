using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISEVID.Models
{
    public class Condicion
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
        public string Descripción { get; set; }

        [ForeignKey("ProgramaId")]
        public Guid ProgramaId { get; set; }

        public virtual  Programa Programa { get; set; }
        public virtual ICollection <Articulo> Articulos { get; set; }

    }
}