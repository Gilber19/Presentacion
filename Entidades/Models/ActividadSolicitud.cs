using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ActividadSolicitud
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("ActividadAsociada")]
    public int ActividadAsociadaId { get; set; }
    public virtual ActividadAsociada ActividadAsociada { get; set; }

    [Required]
    [ForeignKey("Solicitud")]
    public int SolicitudId { get; set; }
    public virtual Solicitud Solicitud { get; set; }

    [Required]
    [StringLength(500)]
    public string Descripcion { get; set; }
}