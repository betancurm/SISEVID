using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISEVID.Models
{
    public class Condicion
    {   
        public Guid Id { get; set; }
        public string Nombre { get; set; }        

        public string Numero { get; set; }

        public string Descripcion { get; set; }
        public Guid ProgramaId { get; set; }

        public virtual  Programa Programa { get; set; }
        public virtual ICollection <Articulo> Articulos { get; set; }

    }
}