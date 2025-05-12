using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class FirmaSolicitud
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("Solicitud")]
    public int SolicitudId { get; set; }
    public virtual Solicitud Solicitud { get; set; }

    [Required]
    [ForeignKey("Usuario")]
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }

    [Required]
    public DateTime FechaFirma { get; set; }
}