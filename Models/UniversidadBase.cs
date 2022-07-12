using System.ComponentModel.DataAnnotations;

namespace SISEVID.Models
{
    public class UniversidadBase
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(20)]
        public string Telefono { get; set; }
        public UniversidadBase()
        {
            
        }
    }
}