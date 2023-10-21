using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class PaisRepository : GenericRepository<Pais>, IPais
    {
        private readonly DbAppContext _context;

        public PaisRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}