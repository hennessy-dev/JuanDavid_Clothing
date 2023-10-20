namespace Dominio.Entidades;
public class Cliente : BaseEntity
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public int IdTipoPersona { get; set; }
    public TipoPersona TipoPersona { get; set; }
    public string FechaRegistro { get; set; }
    public int IdMunicipio { get; set; }
    public Municipio Municipio { get; set; }
}