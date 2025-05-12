namespace Entidades.Models;
public class FirmaSolicitud
{
    public int Id { get; set; }
    public int SolicitudId { get; set; }
    public Solicitud Solicitud { get; set; }
    public int RolId { get; set; }
    public Rol Rol { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}