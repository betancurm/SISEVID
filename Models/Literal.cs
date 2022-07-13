using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISEVID.Models
{
    public class Literal
    {
        public Guid Id { get; set; }
        public string Letra { get; set; }
        public string Descripcion { get; set; }
        public Guid ArticuloId { get; set; }
        public virtual Articulo Articulo { get; set; }
        public virtual ICollection<Numeral> Numerales { get; set; }
    }
}