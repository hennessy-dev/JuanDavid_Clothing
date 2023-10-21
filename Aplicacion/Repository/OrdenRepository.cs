using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class OrdenRepository : GenericRepository<Orden>, IOrden
    {
        private readonly DbAppContext _context;

        public OrdenRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}