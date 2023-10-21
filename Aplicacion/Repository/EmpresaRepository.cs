using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class EmpresaRepository : GenericRepository<Empresa>, IEmpresa
    {
        private readonly DbAppContext _context;

        public EmpresaRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}