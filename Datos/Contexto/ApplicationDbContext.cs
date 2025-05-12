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


        // metodo para configurar el modelo de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
 
        }
    }
}
