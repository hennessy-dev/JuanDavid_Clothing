namespace Dominio.Entidades;
public class Insumo : BaseEntity
{
    public string Nombre { get; set; }
    public int ValorUnit { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set; }
}