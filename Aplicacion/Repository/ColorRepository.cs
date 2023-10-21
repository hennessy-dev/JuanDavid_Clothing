using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class ColorRepository : GenericRepository<Color>, IColor
    {
        private readonly DbAppContext _context;

        public ColorRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}