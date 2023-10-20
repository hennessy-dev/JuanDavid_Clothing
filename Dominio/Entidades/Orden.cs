namespace Dominio.Entidades;
public class Orden : BaseEntity
{
    public string Fecha { get; set; }
    public int IdEmpleado { get; set; }
    public Empleado Empleado { get; set; }
    public int IdCliente { get; set; }
    public Cliente Cliente { get; set; }
    public int IdEstado { get; set; }
    public Estado Estado { get; set; }
}