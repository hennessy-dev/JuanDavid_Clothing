using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class TipoPersonaRepository : GenericRepository<TipoPersona>, ITipoPersona
    {
        private readonly DbAppContext _context;

        public TipoPersonaRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}