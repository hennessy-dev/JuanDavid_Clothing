namespace Dominio.Entidades;
public class Proveedor : BaseEntity
{
    public int NitProveedor { get; set; }
    public string Nombre { get; set; }
    public int IdTipoPersona { get; set; }
    public TipoPersona TipoPersona { get; set; }
    public int IdMunicipio { get; set; }
    public Municipio Municipio { get; set; }
}