namespace Dominio.Entidades;

public class Insumo
{
    public string Nombre { get; set; }
    public int ValorUnit { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set; }
    public ICollection<Prenda> Prendas { get; set; } = new HashSet<Prenda>();
    public ICollection<InsumoPrenda> InsumosPrendas { get; set; }
}