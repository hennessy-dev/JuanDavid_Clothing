using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class ClienteRepository : GenericRepository<Cliente>, ICliente
    {
        private readonly DbAppContext _context;

        public ClienteRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}