using Microsoft.EntityFrameworkCore;
using SISEVID.Models;

namespace SISEVID
{
    public class SisevidContext : DbContext
    {
        public DbSet<Universidad> Universidades { get; set; }
        public DbSet<Sede> Sedes { get; set; }
        public DbSet<Facultad> Facultades { get; set; }
        public DbSet<Programa> Programas { get; set; }
        public DbSet<Condicion> Condiciones { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Literal> Literales { get; set; }
        public DbSet<Numeral> Numerales { get; set; }

        //-------------------------------------------------------------------------------------

        public DbSet<Semestre> Semestres {get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Profesor> Profesores { get; set; }



        public SisevidContext(DbContextOptions<SisevidContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
    
            modelBuilder.Entity<Universidad>(universidad =>
            {
                universidad.ToTable("Universidad");
                universidad.HasKey(p => p.Id);
                universidad.Property(p => p.Nombre).IsRequired().HasMaxLength(150);
                universidad.HasIndex(p => p.Nombre).IsUnique();
                universidad.Property(p => p.Telefono).IsRequired().HasMaxLength(150);
                universidad.HasIndex(p => p.Telefono).IsUnique();             
                
            });
            modelBuilder.Entity<Sede>(sede =>
            {   
                sede.ToTable("Sede");
                sede.HasKey(p => p.Id);
                sede.Property(p=>p.Id).HasColumnOrder(0);
                sede.Property(p => p.Nombre).IsRequired().HasMaxLength(150).HasColumnOrder(1);
                sede.HasIndex(p => p.Nombre).IsUnique();
                sede.Property(p => p.Telefono).IsRequired().HasMaxLength(150).HasColumnOrder(2);
                sede.HasIndex(p => p.Telefono).IsUnique();                
                sede.Property(p => p.Direccion).IsRequired().HasMaxLength(150);
                sede.HasIndex(p=>p.Direccion).IsUnique();
                sede.Property(p => p.Departamento).IsRequired().HasMaxLength(150);
                sede.Property(p => p.Municipio).IsRequired().HasMaxLength(150);
                sede.HasOne(p => p.Universidad).WithMany(p=>p.Sedes).HasForeignKey(p=> p.UniversidadId);
                

            });
            modelBuilder.Entity<Facultad>(facultad =>
            {   
                facultad.ToTable("Facultad");
                facultad.HasKey(p => p.Id);
                facultad.Property(p=>p.Id).HasColumnOrder(0);
                facultad.Property(p => p.Nombre).IsRequired().HasMaxLength(150).HasColumnOrder(1);
                facultad.HasIndex(p => p.Nombre).IsUnique();
                facultad.Property(p => p.Telefono).IsRequired().HasMaxLength(150).HasColumnOrder(2);
                facultad.HasIndex(p => p.Telefono).IsUnique();
                facultad.Property(p => p.Email).IsRequired().HasMaxLength(150);
                facultad.HasIndex(p=>p.Email).IsUnique();
                facultad.HasOne(p=>p.Sede).WithMany(p=>p.Facultades).HasForeignKey(p=>p.SedeId);
            });

            modelBuilder.Entity<Programa>(programa =>
            {   
                programa.ToTable("Programa");
                programa.HasKey(p => p.Id);
                programa.Property(p=>p.Id).HasColumnOrder(0);
                programa.Property(p => p.Nombre).IsRequired().HasMaxLength(150).HasColumnOrder(1);
                programa.HasIndex(p => p.Nombre).IsUnique();
                programa.Property(p => p.Telefono).IsRequired().HasMaxLength(150).HasColumnOrder(2);
                programa.HasIndex(p => p.Telefono).IsUnique();                
                programa.Property(p => p.Email).IsRequired().HasMaxLength(150);
                programa.HasIndex(p=>p.Email).IsUnique();
                programa.Property(p => p.Modalidad).IsRequired().HasMaxLength(150);
                programa.Property(p => p.Duracion).IsRequired().HasMaxLength(150);
                programa.Property(p => p.TituloOtorgado).IsRequired().HasMaxLength(150);
                programa.Property(p => p.Pensum).IsRequired();
                programa.Property(p => p.Descripcion).IsRequired();
                programa.HasOne(p=>p.Facultad).WithMany(p=>p.Programas).HasForeignKey(p=>p.FacultadId);
            });  

            modelBuilder.Entity<Condicion>(condicion =>
            {
                condicion.ToTable("Condicion");
                condicion.HasKey(p=>p.Id);
                condicion.Property(p=>p.Nombre).IsRequired().HasMaxLength(100);
                condicion.Property(p=>p.Numero).IsRequired().HasMaxLength(100);
                condicion.Property(p=>p.Descripcion).IsRequired();
                condicion.HasOne(p=>p.Programa).WithMany(p=>p.Condiciones).HasForeignKey(p=>p.ProgramaId);
            });          

            modelBuilder.Entity<Articulo>(articulo =>
            {
                articulo.ToTable("Articulo");
                articulo.HasKey(p=>p.Id);
                articulo.Property(p=>p.Nombre).IsRequired().HasMaxLength(100);
                articulo.Property(p=>p.Numero).IsRequired().HasMaxLength(100);
                articulo.Property(p=>p.Descripcion).IsRequired();
                articulo.HasOne(p=>p.Condicion).WithMany(p=>p.Articulos).HasForeignKey(p=>p.CondicionId);
            });     
            modelBuilder.Entity<Literal>(literal =>
            {
                literal.ToTable("Literal");
                literal.HasKey(p=>p.Id);
                literal.Property(p=>p.Letra).IsRequired().HasMaxLength(100);
                literal.Property(p=>p.Descripcion).IsRequired();
                literal.HasOne(p=>p.Articulo).WithMany(p=>p.Literales).HasForeignKey(p=>p.ArticuloId);
            });                  
            modelBuilder.Entity<Numeral>(numeral =>
            {
                numeral.ToTable("Numeral");
                numeral.HasKey(p=>p.Id);
                numeral.Property(p=>p.Numero).IsRequired().HasMaxLength(100);
                numeral.HasOne(p=>p.Literal).WithMany(p=>p.Numerales).HasForeignKey(p=>p.LiteralId);
            });                  
        
        }
    }
}