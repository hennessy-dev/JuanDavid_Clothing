using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class CargoRepository : GenericRepository<Cargo>, ICargo
    {
        private readonly DbAppContext _context;

        public CargoRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}