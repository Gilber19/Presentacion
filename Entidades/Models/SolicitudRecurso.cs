namespace Entidades.Models;
public class SolicitudRecurso
{
    public int Id { get; set; }
    public int SolicitudId { get; set; }
    public Solicitud Solicitud { get; set; }
    public int RecursoId { get; set; }
    public Recurso Recurso { get; set; }
    public string OtroRecursoDescripcion { get; set; } // solo si es 'Otro'
    public string Detalles { get; set; }
}

