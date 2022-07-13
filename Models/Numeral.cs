using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISEVID.Models
{
    public class Numeral
    {   
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public string Descripcion { get; set; }
        public Guid LiteralId { get; set; }

        public virtual Literal Literal { get; set; }


    }
}