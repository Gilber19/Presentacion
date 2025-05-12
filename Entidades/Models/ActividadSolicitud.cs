namespace Entidades.Models;
public class ActividadSolicitud
{
    public int ActividadId { get; set; }
    public ActividadAsociada Actividad { get; set; }
    public int SolicitudId { get; set; }
    public Solicitud Solicitud { get; set; }
    public string Descripcion { get; set; }
}