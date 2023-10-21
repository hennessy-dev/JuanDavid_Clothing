using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class DetalleVentaRepository : GenericRepository<DetalleVenta>, IDetalleVenta
    {
        private readonly DbAppContext _context;

        public DetalleVentaRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}