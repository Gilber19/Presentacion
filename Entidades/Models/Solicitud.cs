using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Solicitud
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "La fecha de inicio es requerida")]
    public DateTime FechaInicio { get; set; }

    [Required(ErrorMessage = "La fecha de fin es requerida")]
    public DateTime FechaFin { get; set; }

    [Required]
    [ForeignKey("Usuario")]
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }

    public virtual ICollection<ActividadSolicitud> ActividadesSolicitud { get; set; }
    public virtual ICollection<FirmaSolicitud> FirmasSolicitud { get; set; }
    public virtual ICollection<SolicitudRecurso> SolicitudesRecursos { get; set; }
}