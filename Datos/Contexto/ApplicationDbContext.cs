using Microsoft.EntityFrameworkCore;
using Entidades.Models;

namespace Datos.Contexto
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor que recibe las opciones de configuración
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        // Propiedades DbSet para cada entidad
        public DbSet<ActividadAsociada> ActividadesAsociadas { get; set; }
        public DbSet<ActividadSolicitud> ActividadesSolicitud { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Estado> Estados { get; set; }
       // public DbSet<EstadoSolicitud> EstadosSolicitud { get; set; }
        public DbSet<FirmaSolicitud> FirmasSolicitud { get; set; }
       // public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<SolicitudRecurso> SolicitudesRecursos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        // Fix for the errors related to the use of 'as' as a variable name.  
        // 'as' is a reserved keyword in C#, so it cannot be used as a variable name.  
        // Renaming the lambda parameter from 'as' to 'actividadSolicitud' to resolve the issue.  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Usuario  
            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Correo)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.NumEmpleado)
                .IsUnique();

            // Solicitud  
            modelBuilder.Entity<Solicitud>()
                .HasMany(s => s.ActividadesSolicitud)
                .WithOne(actividadSolicitud => actividadSolicitud.Solicitud)
                .HasForeignKey(actividadSolicitud => actividadSolicitud.SolicitudId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Solicitud>()
                .HasMany(s => s.FirmasSolicitud)
                .WithOne(f => f.Solicitud)
                .HasForeignKey(f => f.SolicitudId)
                .OnDelete(DeleteBehavior.Cascade);

            // ActividadAsociada  
            modelBuilder.Entity<ActividadAsociada>()
                .HasMany(a => a.ActividadesSolicitud)
                .WithOne(actividadSolicitud => actividadSolicitud.ActividadAsociada)
                .HasForeignKey(actividadSolicitud => actividadSolicitud.ActividadAsociadaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Usuario - Roles (many-to-one)  
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Rol)
                .WithMany()
                .HasForeignKey(u => u.RolId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuring relationships with delete behavior  
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Carrera)
                .WithMany()
                .HasForeignKey(u => u.CarreraId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Categoria)
                .WithMany()
                .HasForeignKey(u => u.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Estado)
                .WithMany()
                .HasForeignKey(u => u.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
