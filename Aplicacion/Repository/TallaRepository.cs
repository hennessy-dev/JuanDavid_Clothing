using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class TallaRepository : GenericRepository<Talla>, ITalla
    {
        private readonly DbAppContext _context;

        public TallaRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}