namespace Dominio.Entidades;
public class Estado : BaseEntity
{
    public string Descripcion { get; set; }
    public int Id_TipoEstado { get; set; }
    public TipoEstado TipoEstado { get; set; }
    public ICollection<Prenda> Prendas { get; set; }
    public ICollection<DetalleOrden> DetallesOrdenes { get; set; }
    public ICollection<Orden> Ordenes { get; set; }
}