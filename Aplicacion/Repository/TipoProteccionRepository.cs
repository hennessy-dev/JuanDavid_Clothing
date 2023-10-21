using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class TipoProteccionRepository : GenericRepository<TipoProteccion>, ITipoProteccion
    {
        private readonly DbAppContext _context;

        public TipoProteccionRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}