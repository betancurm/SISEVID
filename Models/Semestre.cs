namespace SISEVID.Models
{
    public class Semestre
    {
        public Guid Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public virtual ICollection<Asignatura> Asignaturas {get; set;}
    }
}