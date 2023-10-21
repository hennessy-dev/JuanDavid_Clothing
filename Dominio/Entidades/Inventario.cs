namespace Dominio.Entidades;

public class Inventario : BaseEntity
{
    public int CodInv { get; set; }
    public int Id_Prenda { get; set; }
    public Prenda Prenda { get; set; }
    public double ValorVtaTotal { get; set; }
    public double ValorVtaUsd { get; set; }
    public ICollection<InventarioTalla> InventarioTallas { get; set; }
    public ICollection<DetalleVenta> DetallesVentas { get; set; }
}
