using System.Threading.Tasks;
using Datos.Contexto;
using Datos.Repositories;
using Entidades.Models;

namespace Datos.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<ActividadAsociada> ActividadesAsociadas { get; }
        IGenericRepository<ActividadSolicitud> ActividadesSolicitud { get; }
        IGenericRepository<Carrera> Carreras { get; }
        IGenericRepository<Categoria> Categorias { get; }
        IGenericRepository<Estado> Estados { get; }
        //IGenericRepository<EstadoSolicitud> EstadosSolicitud { get; } TODO
        IGenericRepository<FirmaSolicitud> FirmasSolicitud { get; }
        //IGenericRepository<Recurso> Recursos { get; } TODO
        IGenericRepository<Rol> Roles { get; }
        IGenericRepository<Solicitud> Solicitudes { get; }
        IGenericRepository<SolicitudRecurso> SolicitudesRecursos { get; }
        IGenericRepository<Usuario> Usuarios { get; }

        Task<int> SaveChangesAsync();
    }
}
