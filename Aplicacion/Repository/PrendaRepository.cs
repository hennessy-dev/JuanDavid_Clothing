using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class PrendaRepository : GenericRepository<Prenda>, IPrenda
    {
        private readonly DbAppContext _context;

        public PrendaRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}