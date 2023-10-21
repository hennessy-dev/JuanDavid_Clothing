using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class InventarioRepository : GenericRepository<Inventario>, IInventario
    {
        private readonly DbAppContext _context;

        public InventarioRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}