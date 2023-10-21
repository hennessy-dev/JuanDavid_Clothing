using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class TipoEstadoRepository : GenericRepository<TipoEstado>, ITipoEstado
    {
        private readonly DbAppContext _context;

        public TipoEstadoRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}