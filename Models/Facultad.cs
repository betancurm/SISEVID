using System.ComponentModel.DataAnnotations;

namespace SISEVID.Models
{
    public class Facultad : UniversidadBase
    {
        public string Email { get; set; }
        public Guid SedeId { get; set; }
        public virtual Sede Sede { get; set; }
        public virtual ICollection <Programa> Programas { get; set; }
    }
}