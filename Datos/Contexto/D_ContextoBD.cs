using Microsoft.EntityFrameworkCore;
using Entidades.Models;

namespace Datos.Contexto
{
    public class D_ContextoBD : DbContext
    {
        public D_ContextoBD(DbContextOptions<D_ContextoBD> options) : base(options)
        {
        }

        // Propiedades DbSet para cada entidad
        public DbSet<ActividadAsociada> ActividadesAsociadas { get; set; }
        public DbSet<ActividadSolicitud> ActividadesSolicitud { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<FirmaSolicitud> FirmasSolicitud { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<SolicitudRecurso> SolicitudesRecursos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuraciones de Usuario
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasIndex(u => u.Correo).IsUnique();
                entity.HasIndex(u => u.NumEmpleado).IsUnique();
                
                entity.HasOne(u => u.Rol)
                    .WithMany()
                    .HasForeignKey(u => u.RolId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(u => u.Carrera)
                    .WithMany()
                    .HasForeignKey(u => u.CarreraId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(u => u.Categoria)
                    .WithMany()
                    .HasForeignKey(u => u.CategoriaId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(u => u.Estado)
                    .WithMany()
                    .HasForeignKey(u => u.EstadoId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Configuraciones de Solicitud
            modelBuilder.Entity<Solicitud>(entity =>
            {
                entity.HasOne(s => s.Usuario)
                    .WithMany()
                    .HasForeignKey(s => s.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(s => s.ActividadesSolicitud)
                    .WithOne(a => a.Solicitud)
                    .HasForeignKey(a => a.SolicitudId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(s => s.FirmasSolicitud)
                    .WithOne(f => f.Solicitud)
                    .HasForeignKey(f => f.SolicitudId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Configuraciones de ActividadSolicitud
            modelBuilder.Entity<ActividadSolicitud>(entity =>
            {
                entity.HasOne(a => a.ActividadAsociada)
                    .WithMany(aa => aa.ActividadesSolicitud)
                    .HasForeignKey(a => a.ActividadAsociadaId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Configuraciones de FirmaSolicitud
            modelBuilder.Entity<FirmaSolicitud>(entity =>
            {
                entity.HasOne(f => f.Usuario)
                    .WithMany(u => u.FirmasSolicitud)
                    .HasForeignKey(f => f.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Configuraciones de SolicitudRecurso
            modelBuilder.Entity<SolicitudRecurso>(entity =>
            {
                entity.HasOne(sr => sr.Solicitud)
                    .WithMany(s => s.SolicitudesRecursos)
                    .HasForeignKey(sr => sr.SolicitudId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
