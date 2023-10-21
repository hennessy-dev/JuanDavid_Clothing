using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamento
    {
        private readonly DbAppContext _context;

        public DepartamentoRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}