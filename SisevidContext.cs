using Microsoft.EntityFrameworkCore;
using SISEVID.Models;

namespace SISEVID
{
    public class SisevidContext : DbContext
    {
        public DbSet<Universidad> Universidades {get; set;}
        public DbSet<Sede> Sedes { get; set; }
        public DbSet<Facultad> Facultades { get; set; }
        public DbSet<Programa> Programas { get; set; }
        public DbSet<Condicion> Condiciones {get; set; }
        public DbSet<Articulo> Articulos{get; set; }
        public DbSet<Literal> Literales {get; set; }
        public DbSet<Numeral> Numerales {get; set; }

        
        public SisevidContext(DbContextOptions<SisevidContext> options): base(options){}
    }
}