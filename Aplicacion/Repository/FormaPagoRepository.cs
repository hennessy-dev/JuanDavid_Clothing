using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class FormaPagoRepository : GenericRepository<FormaPago>, IFormaPago
    {
        private readonly DbAppContext _context;

        public FormaPagoRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}