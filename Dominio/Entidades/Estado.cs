namespace Dominio.Entidades;
public class Estado : BaseEntity
{
    public string Descripcion { get; set; }
    public int IdTipoEstado { get; set; }
    public TipoEstado TipoEstado { get; set; }
}