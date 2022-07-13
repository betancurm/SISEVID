using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISEVID.Models
{
    public class Articulo
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }        
        public string Numero { get; set; }
        public string Descripcion { get; set; }
        public Guid CondicionId { get; set; }

        public virtual Condicion Condicion { get; set; }
        
        public virtual ICollection<Literal> Literales {get;set;}
    }
}