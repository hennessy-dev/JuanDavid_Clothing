namespace Dominio.Entidades;

public class Proveedor : BaseEntity
{
    public int NitProveedor { get; set; }
    public string Nombre { get; set; }
    public int Id_TipoPersona { get; set; }
    public TipoPersona TipoPersona { get; set; }
    public int Id_Municipio { get; set; }
    public Municipio Municipio { get; set; }
    public ICollection<InsumoProveedor> InsumosProveedores { get; set; }
    public ICollection<Insumo> Insumos { get; set; } = new HashSet<Insumo>();
}
