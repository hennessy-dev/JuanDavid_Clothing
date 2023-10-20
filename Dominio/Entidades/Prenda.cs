namespace Dominio.Entidades;
public class Prenda : BaseEntity
{
    public int IdPrenda { get; set; }
    public string Nombre { get; set; }
    public double ValorUnitCop { get; set; }
    public double ValorUnitUsd { get; set; }
    public int IdEstado { get; set; }
    public Estado Estado { get; set; }
    public int IdTipoProteccion { get; set; }
    public TipoProteccion TipoProteccion { get; set; }
    public int IdGenero { get; set; }
    public Genero Genero { get; set; }
}