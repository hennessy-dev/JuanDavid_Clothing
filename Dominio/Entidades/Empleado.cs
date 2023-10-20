namespace Dominio.Entidades;
public class Empleado : BaseEntity
{
    public int IdEmpleado { get; set; }
    public string Nombre { get; set; }
    public int IdCargo { get; set; }
    public Cargo Cargo { get; set; }
    public string FechaIngreso { get; set; }
    public int IdMunicipio { get; set; }
    public Municipio Municipio { get; set; }
}