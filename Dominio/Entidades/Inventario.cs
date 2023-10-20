namespace Dominio.Entidades;
public class Inventario : BaseEntity
{
    public int CodInv { get; set; }
    public int IdPrenda { get; set; }
    public Prenda Prenda { get; set; }
    public int ValorVentaCop { get; set; }
    public int ValorVentaUsd { get; set; }
}