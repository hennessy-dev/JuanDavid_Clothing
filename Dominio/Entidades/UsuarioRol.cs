namespace Dominio.Entidades;

public class UsuarioRol : BaseEntity
{
    public int Id_Usuario { get; set; }
    public Usuario Usuario { get; set; }
    public int Id_Rol { get; set; }
    public Rol Rol { get; set; }
}
