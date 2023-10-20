namespace Dominio.Entidades;
public class DetalleOrden : BaseEntity
{
    public int IdOrden { get; set; }
    public int IdPrenda { get; set; }
    public Prenda Prenda { get; set; }
    public int CantidadProducido { get; set; }
    public int IdEstado { get; set; }
    public Estado Estado { get; set; }
}