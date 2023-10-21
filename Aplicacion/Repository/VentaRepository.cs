using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class VentaRepository : GenericRepository<Venta>, IVenta
    {
        private readonly DbAppContext _context;

        public VentaRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}