using Entidades.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es requerido")]
    [StringLength(100)]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El apellido paterno es requerido")]
    [StringLength(100)]
    public string ApellidoPaterno { get; set; }

    [StringLength(100)]
    public string ApellidoMaterno { get; set; }

    [Required(ErrorMessage = "El correo es requerido")]
    [EmailAddress(ErrorMessage = "Formato de correo inválido")]
    [StringLength(100)]
    public string Correo { get; set; }

    [Required(ErrorMessage = "La contraseña es requerida")]
    [StringLength(100, MinimumLength = 6)]
    public string Password { get; set; }

    [Required]
    public int NumEmpleado { get; set; }

    [Required]
    [ForeignKey("Carrera")]
    public int CarreraId { get; set; }
    public virtual Carrera Carrera { get; set; }

    [Required]
    [ForeignKey("Categoria")]
    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }

    [Required]
    [ForeignKey("Estado")]
    public int EstadoId { get; set; }
    public virtual Estado Estado { get; set; }

    [Required]
    [ForeignKey("Rol")]
    public int RolId { get; set; }
    public virtual Rol Rol { get; set; }

    public virtual ICollection<FirmaSolicitud> FirmasSolicitud { get; set; }
}