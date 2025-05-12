using System.ComponentModel.DataAnnotations;
namespace Entidades.Models;
public class Usuario
{
    public int Id { get; set; }
    [Required, MaxLength(100)] public string Nombre { get; set; }
    [Required, MaxLength(45)] public string ApellidoPaterno { get; set; }
    [MaxLength(45)] public string ApellidoMaterno { get; set; }
    [Required, MaxLength(100)] public string Correo { get; set; }
    [Required, MaxLength(120)] public string Password { get; set; }
    [Required] public int NumEmpleado { get; set; }

    public int CarreraId { get; set; }
    public Carrera Carrera { get; set; }
    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; }
    public int EstadoId { get; set; }
    public Estado Estado { get; set; }
}