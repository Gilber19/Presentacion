using System.Threading.Tasks;
using Datos.Contexto;
using Datos.Repositories;
using Entidades.Models;

namespace Datos.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly D_ContextoBD _context;
        
        public IGenericRepository<ActividadAsociada> ActividadesAsociadas { get; private set; }
        public IGenericRepository<ActividadSolicitud> ActividadesSolicitud { get; private set; }
        public IGenericRepository<Carrera> Carreras { get; private set; }
        public IGenericRepository<Categoria> Categorias { get; private set; }
        public IGenericRepository<Estado> Estados { get; private set; }
        //public IGenericRepository<EstadoSolicitud> EstadosSolicitud { get; private set; }
        public IGenericRepository<FirmaSolicitud> FirmasSolicitud { get; private set; }
        //public IGenericRepository<Recurso> Recursos { get; private set; }
        public IGenericRepository<Rol> Roles { get; private set; }
        public IGenericRepository<Solicitud> Solicitudes { get; private set; }
        public IGenericRepository<SolicitudRecurso> SolicitudesRecursos { get; private set; }
        public IGenericRepository<Usuario> Usuarios { get; private set; }

        public UnitOfWork(D_ContextoBD context)
        {
            _context = context;
            ActividadesAsociadas = new GenericRepository<ActividadAsociada>(context);
            ActividadesSolicitud = new GenericRepository<ActividadSolicitud>(context);
            Carreras = new GenericRepository<Carrera>(context);
            Categorias = new GenericRepository<Categoria>(context);
            Estados = new GenericRepository<Estado>(context);
            //EstadosSolicitud = new GenericRepository<EstadoSolicitud>(context);
            FirmasSolicitud = new GenericRepository<FirmaSolicitud>(context);
            //Recursos = new GenericRepository<Recurso>(context);
            Roles = new GenericRepository<Rol>(context);
            Solicitudes = new GenericRepository<Solicitud>(context);
            SolicitudesRecursos = new GenericRepository<SolicitudRecurso>(context);
            Usuarios = new GenericRepository<Usuario>(context);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
