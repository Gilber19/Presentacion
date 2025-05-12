using System.ComponentModel.DataAnnotations;

namespace Entidades.Models;
public class Rol
{
    public int Id { get; set; }
    [Required, MaxLength(100)] public string Descripcion { get; set; }
    [MaxLength(100)] public string Correo { get; set; }
    [Required, MaxLength(120)] public string Password { get; set; }

    public int CarreraId { get; set; }
    public Carrera Carrera { get; set; }
}

