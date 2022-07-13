using System.ComponentModel.DataAnnotations;

namespace SISEVID.Models
{
    public class UniversidadBase
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public UniversidadBase()
        {
            
        }
    }
}