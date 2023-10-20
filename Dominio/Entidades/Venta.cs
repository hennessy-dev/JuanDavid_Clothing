namespace Dominio.Entidades;
public class Venta : BaseEntity
{
    public string Fecha { get; set; }
    public int IdEmpleado { get; set; }
    public Empleado Empleado { get; set; }
    public int IdCliente { get; set; }
    public Cliente Cliente { get; set; }
    public int IdFormaPago { get; set; }
    public FormaPago FormaPago { get; set; }
}