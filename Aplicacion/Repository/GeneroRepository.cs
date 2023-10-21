using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class GeneroRepository : GenericRepository<Genero>, IGenero
    {
        private readonly DbAppContext _context;

        public GeneroRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}