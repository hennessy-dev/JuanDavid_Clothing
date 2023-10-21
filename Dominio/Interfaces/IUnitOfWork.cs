namespace Dominio.Interfaces;

public interface IUnitOfWork
{
    IUsuario Usuarios {get;}
    IRol Roles {get;}
    ICargo Cargos {get;}
    ICliente Clientes {get;}
    IColor Colores {get;}
    IDepartamento Departamentos {get;}
    IDetalleOrden DetallesOrdenes {get;}
    IDetalleVenta DetallesVentas {get;}
    IPais Paises {get;}
    IInsumo Insumos {get;}
    IInventario Inventarios {get;}
    ITalla Tallas {get;}
    IPrenda Prendas {get;}
    IProveedor Proveedores {get;}
    IEmpleado Empleados {get;}
    IVenta Ventas {get;}
    IMunicipio Municipios {get;}
    IEmpresa Empresas {get;}
    ITipoProteccion TipoProtecciones {get;}
    ITipoPersona TipoPersonas {get;}
    IGenero Generos {get;}
    IEstado Estados {get;}
    ITipoEstado TipoEstados {get;}
    IFormaPago FormaPagos {get;}
    IOrden Ordenes {get;}
    Task<int> SaveAsync();
}
