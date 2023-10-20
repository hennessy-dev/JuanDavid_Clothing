namespace Dominio.Entidades;
public class Municipio : BaseEntity
{
    public string Nombre { get; set; }
    public int IdDep { get; set; }
    public Departamento Departamento { get; set; }
}