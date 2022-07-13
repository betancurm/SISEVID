using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISEVID.Models
{
    public class Programa : UniversidadBase
    {
        public string Email { get; set; }
        public Modalidad Modalidad { get; set; }
        public string Duracion { get; set; }
        public string TituloOtorgado { get; set; }
        public Byte[] Pensum { get; set; }
        public string Descripcion { get; set; }
        public Guid FacultadId { get; set; }
        public virtual Facultad Facultad { get; set; }
        public virtual ICollection<Condicion> Condiciones { get; set; }
    }

    public enum Modalidad
    {
        Presencial, SemiPresencial, Distancia, Virtual,
    }
}