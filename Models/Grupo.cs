namespace SISEVID.Models
{
    public class Grupo
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public Guid AsignaturaId { get; set; }
        public virtual Asignatura Asignatura { get; set; }
        public Guid ProfesorId { get; set; }
        public virtual Profesor Profesor { get; set; }
    }
}