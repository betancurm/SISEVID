using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISEVID.Models
{
    public class Programa: UniversidadBase
    {
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }        
        [Required]
        public Modalidad Modalidad { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Duracion { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string TituloOtorgado { get; set; }
        
        [Required]
        public Byte[] Pensum { get; set; }
        
        [Required]
        public string Descripcion { get; set; }
        
        [ForeignKey("FacultadId")]
        public Guid FacultadId { get; set; }
        public virtual Facultad Facultad { get; set; }
        public virtual ICollection <Condicion> Condiciones { get; set; }


    }

    public enum Modalidad
    {
        Presencial, SemiPresencial, Distancia, Virtual, 
    }
}