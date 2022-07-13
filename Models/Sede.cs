using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISEVID.Models
{
    public class Sede: UniversidadBase
    {
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public Guid UniversidadId { get; set; }
        public virtual Universidad Universidad {get; set; }
        public  virtual ICollection<Facultad> Facultades { get; set; }
    }
}