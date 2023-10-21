using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Application.Repository
{
    public class EmpleadoRepository : GenericRepository<Empleado>, IEmpleado
    {
        private readonly DbAppContext _context;

        public EmpleadoRepository(DbAppContext context) : base (context)
        {
            _context = context;
        }
    }
}