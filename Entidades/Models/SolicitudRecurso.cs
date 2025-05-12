using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SolicitudRecurso
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("Solicitud")]
    public int SolicitudId { get; set; }
    public virtual Solicitud Solicitud { get; set; }

    [Required]
    [StringLength(200)]
    public string Descripcion { get; set; }

    [Required]
    public int Cantidad { get; set; }
}