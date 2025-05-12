using System.ComponentModel.DataAnnotations;

public class ActividadAsociada
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(200)]
    public string Nombre { get; set; }

    [StringLength(500)]
    public string Descripcion { get; set; }

    public virtual ICollection<ActividadSolicitud> ActividadesSolicitud { get; set; }
}