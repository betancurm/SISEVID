namespace SISEVID.Models
{
    public class Asignatura
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }  
        public string Area { get; set; }
        public int Creditos { get; set; }
        public string Prerrequisito { get; set; }
        public Guid SemestreId { get; set; }
        public virtual Semestre Semestre { get; set; }
        public virtual ICollection<Grupo> Grupos { get; set; }
        }
}