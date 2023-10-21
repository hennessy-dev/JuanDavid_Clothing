using Aplicacion.Repository;
using Application.Repository;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly DbAppContext _dbContext;
    public UnitOfWork(DbAppContext context)
    {
        _dbContext = context;
    }

    private IDetalleVenta _DetalleVenta;
    public IDetalleVenta DetallesVentas
    {
        get { 
            _DetalleVenta ??= new DetalleVentaRepository(_dbContext);
                return _DetalleVenta;
            }
    }

    private IInsumo _Insumo;
    public IInsumo Insumos
    {
        get { 
            _Insumo ??= new InsumoRepository(_dbContext);
                return _Insumo;
            }
    }
    private IGenero _Genero;
    public IGenero Generos
    {
        get { 
            _Genero ??= new GeneroRepository(_dbContext);
                return _Genero;
            }
    }
    private ITalla _Talla;
    public ITalla Tallas
    {
        get { 
            _Talla ??= new TallaRepository(_dbContext);
                return _Talla;
            }
    }
    private IInventario _Inventario;
    public IInventario Inventarios
    {
        get { 
            _Inventario ??= new InventarioRepository(_dbContext);
                return _Inventario;
            }
    }

    private IPais _Pais;
    public IPais Paises
    {
        get { 
            _Pais ??= new PaisRepository(_dbContext);
                return _Pais;
            }
    }

    private ICargo _Cargo;
    public ICargo Cargos
    {
        get { 
            _Cargo ??= new CargoRepository(_dbContext);
                return _Cargo;
            }
    }

    private ICliente _Cliente;
    public ICliente Clientes
    {
        get { 
            _Cliente ??= new ClienteRepository(_dbContext);
                return _Cliente;
            }
    }

    private IColor _Color;
    public IColor Colores
    {
        get { 
            _Color ??= new ColorRepository(_dbContext);
                return _Color;
            }
    }

    private IDepartamento _Departamento;
    public IDepartamento Departamentos
    {
        get { 
            _Departamento ??= new DepartamentoRepository(_dbContext);
                return _Departamento;
            }
    }

    private IDetalleOrden _DetalleOrden;
    public IDetalleOrden DetallesOrdenes
    {
        get { 
            _DetalleOrden ??= new DetalleOrdenRepository(_dbContext);
                return _DetalleOrden;
            }
    }

    private IPrenda _Prenda;
    public IPrenda Prendas
    {
        get { 
            _Prenda ??= new PrendaRepository(_dbContext);
                return _Prenda;
            }
    }

    private IProveedor _Proveedor;
    public IProveedor Proveedores
    {
        get { 
            _Proveedor ??= new ProveedorRepository(_dbContext);
                return _Proveedor;
            }
    }

    private IEmpleado _Empleado;
    public IEmpleado Empleados
    {
        get { 
            _Empleado ??= new EmpleadoRepository(_dbContext);
                return _Empleado;
            }
    }

    private IVenta _Venta;
    public IVenta Ventas
    {
        get { 
            _Venta ??= new VentaRepository(_dbContext);
                return _Venta;
            }
    }

    private IMunicipio _Municipio;
    public IMunicipio Municipios
    {
        get { 
            _Municipio ??= new MunicipioRepository(_dbContext);
                return _Municipio;
            }
    }

    private IEmpresa _Empresa;
    public IEmpresa Empresas
    {
        get { 
            _Empresa ??= new EmpresaRepository(_dbContext);
                return _Empresa;
            }
    }

    private ITipoProteccion _TipoProteccion;
    public ITipoProteccion TipoProtecciones
    {
        get { 
            _TipoProteccion ??= new TipoProteccionRepository(_dbContext);
                return _TipoProteccion;
            }
    }

    private ITipoPersona _TipoPersona;
    public ITipoPersona TipoPersonas
    {
        get { 
            _TipoPersona ??= new TipoPersonaRepository(_dbContext);
                return _TipoPersona;
            }
    }

    private IEstado _Estado;
    public IEstado Estados
    {
        get { 
            _Estado ??= new EstadoRepository(_dbContext);
                return _Estado;
            }
    }

    private ITipoEstado _TipoEstado;
    public ITipoEstado TipoEstados
    {
        get { 
            _TipoEstado ??= new TipoEstadoRepository(_dbContext);
                return _TipoEstado;
            }
    }

    private IFormaPago _FormaPago;
    public IFormaPago FormaPagos
    {
        get { 
            _FormaPago ??= new FormaPagoRepository(_dbContext);
                return _FormaPago;
            }
    }

    private IOrden _Orden;
    public IOrden Ordenes
    {
        get { 
            _Orden ??= new OrdenRepository(_dbContext);
                return _Orden;
            }
    }
    UsuarioRepository _usuario;
    RolRepository _rol;

    public IUsuario Usuarios
    {
        get
        {
            if (_usuario is not null)
            {
                return _usuario;
            }
            return _usuario = new UsuarioRepository(_dbContext);
        }
    }
    public IRol Roles
    {
        get
        {
            if (_rol is not null)
            {
                return _rol;
            }
            return _rol = new RolRepository(_dbContext);
        }
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }
    public async Task<int> SaveAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }
}
