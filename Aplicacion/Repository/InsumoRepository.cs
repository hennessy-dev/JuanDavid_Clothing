using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class InsumoRepository : GenericRepository<Insumo>, IInsumo
    {
        private readonly DbAppContext _context;

        public InsumoRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}