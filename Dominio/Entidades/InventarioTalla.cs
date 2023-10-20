namespace Dominio.Entidades;
public class InventarioTalla : BaseEntity
{
    public int IdInv { get; set; }
    public Inventario Inventario { get; set; }
    public int IdTalla { get; set; }
    public Talla Talla { get; set; }
    public int Cantidad { get; set; }
}