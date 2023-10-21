namespace Dominio.Entidades;
public class Empleado : BaseEntity
{
    public int Id_Empleado { get; set; }
    public string Nombre { get; set; }
    public int Id_Cargo { get; set; }
    public Cargo Cargo { get; set; }
    public DateTime FechaIngreso { get; set; }
    public int Id_Municipio { get; set; }
    public Municipio Municipio { get; set; }
    public ICollection<Orden> Ordenes { get; set; }
    public ICollection<DetalleVenta> DetallesVentas { get; set; }
    public ICollection<Venta> Ventas { get; set; }
}
