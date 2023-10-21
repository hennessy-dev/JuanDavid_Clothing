using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class EstadoRepository : GenericRepository<Estado>, IEstado
    {
        private readonly DbAppContext _context;

        public EstadoRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}