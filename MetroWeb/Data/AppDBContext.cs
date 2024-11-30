using Microsoft.EntityFrameworkCore; // Carlos L : paquete Intalado
using MetroWeb.Models; // Carlos L : referencia a la tabla
namespace MetroWeb.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options): base(options) 
        {
            
        }
        // Definicon de las tablas de la base de datos
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(tb =>
            {
                tb.HasKey(col => col.IdUsuario);
                tb.Property(col => col.IdUsuario)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.NombreCompleto).HasMaxLength(50);
                tb.Property(col => col.Correo).HasMaxLength(50);
                tb.Property(col => col.Clave).HasMaxLength(50);
                tb.Property(col => col.Cedula).HasMaxLength(14);
                tb.Property(col => col.FechaNacimiento);
            });
            // Carlos L: Espesifico el nombre que quiero para la tabla
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
        }


    }

}
