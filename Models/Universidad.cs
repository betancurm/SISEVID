namespace SISEVID.Models
{
    public class Universidad : UniversidadBase
    {
        public virtual ICollection<Sede> Sedes { get; set; }
    }
}