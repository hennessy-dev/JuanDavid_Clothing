using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class DetalleOrdenRepository : GenericRepository<DetalleOrden>, IDetalleOrden
    {
        private readonly DbAppContext _context;

        public DetalleOrdenRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}