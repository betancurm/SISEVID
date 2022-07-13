namespace SISEVID.Models
{
    public class Profesor
    {
        public Guid  Id { get; set; }
        public string Carnet { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }
        public string Email{ get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string Documento { get; set; }
        public virtual ICollection<Grupo> Grupos {get; set;}
    }

    public enum TipoDocumento
    {
        Cedula, TarjetaIdentidad, Pasaporte,
    }
}