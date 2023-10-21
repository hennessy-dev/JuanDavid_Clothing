namespace Dominio.Entidades;
public class DetalleVenta : BaseEntity
{
    public int Id_Venta { get; set; }
    public Venta Venta { get; set; }
    public int Id_Producto { get; set; }
    public Inventario Inventario { get; set; }
    public int Id_Talla { get; set; }
    public Talla Talla { get; set; }
    public int Cantidad { get; set; }
    public double ValorUnit { get; set; }
}
