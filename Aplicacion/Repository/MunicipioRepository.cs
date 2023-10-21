using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class MunicipioRepository : GenericRepository<Municipio>, IMunicipio
    {
        private readonly DbAppContext _context;

        public MunicipioRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}